const express = require('express');
const mysql = require('mysql');
const multer = require('multer');
const cors = require('cors');
const bodyParser = require('body-parser');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const app = express();
app.use(cors());
app.use(express.json());
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

  

const db = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'furniture',
});

db.connect((err) => {
  if (err) throw err;
  console.log('Connected to MySQL database');
});

const SECRET_KEY ='06032002';

const verifyToken = (req, res, next) => {
  const token = req.headers.authorization;
  
  if (!token) {
    return res.status(401).send({ error: 'No token provided' });
  }

  jwt.verify(token, SECRET_KEY, (err, decoded) => {
    if (err) {
      return res.status(401).send({ error: 'Invalid token' });
    }
    next();
  });
};

// Create account endpoint
app.post('/create-account', (req, res) => {
  const { username, password } = req.query;

  if (!username || !password ) {
    res.status(400).send({ error: 'Missing parameter or role ID error' });
    return;
  }

  const token = jwt.sign({ username }, SECRET_KEY); // Generate JWT token

  bcrypt.hash(password, 10, (err, hashedPassword) => {
    if (err) {
      console.error('Error hashing password:', err);
      res.status(500).send({ error: 'Error creating account' });
      return;
    }

    const query =
      'INSERT INTO `account`( `Username`, `Password`, `Token`) VALUES (?,?,?)';

    db.query(query, [username, hashedPassword, token], (err, result) => {
      if (err) {
        console.error('Error creating account:', err);
        res.status(500).send({ error: 'Error creating account' });
      } else {
        res.status(200).send({ message: 'Account created successfully' });
      }
    });
  });
});

app.post('/login', (req, res) => {
  const { username, password } = req.query;
console.log(req.query);
  if (!username || !password) {
    res.status(400).send({ error: 'Missing username or password' });
    return;
  }

  const query =
  "SELECT * FROM account WHERE Username=?";
  db.query(query, [username], (err, result) => {
    if (err) {
      res.status(500).send({ error: 'Error fetching data' });
      return;
    }
    if (result.length === 0) {
      res.status(401).send({ error: 'Invalid credentials' });
      return;
    }
    const hashedPassword = result[0].Password;
    bcrypt.compare(password, hashedPassword, (err, passwordMatch) => {
      if (err) {
        res.status(500).send({ error: 'Error logging in' });
        return;
      }

      if (passwordMatch) {
        res.status(200).send(result);
      } else {
        res.status(401).send({ error: 'Invalid password' });
      }
    });
  });
});


app.get('/furniture', verifyToken, (req, res) => {
  const displayData = req.query.displayData;
  let sqlQuery;
  if (displayData === 'MaxID') {
    sqlQuery =  "SELECT MAX(`Customer ID`) as maxID from customer_info";
  } 
  else if (displayData === "ORDERDETAIL") {
    sqlQuery = "SELECT * FROM `order_detail`";
  }
  else if (displayData === "ord") {
    sqlQuery =  "SELECT `order_detail`.`Order ID`, `customer_info`.`Customer Name`, `furniture_available`.`Furniture name`, `order_detail`.`Quantity`, `order_detail`.`Price`, `order_detail`.`Sub-total`, `order_detail`.`Order_Date` FROM((`order_detail` INNER JOIN `customer_info` ON `order_detail`.` Customer ID` = `customer_info`.`Customer ID`) INNER JOIN `furniture_available` ON `order_detail`.`Furniture ID` = `furniture_available`.`Furniture ID`) where status='Unpaid'";
  } 
  else {
    return res.status(400).send({ error: 'Invalid displayData value' });
  }
  db.query(sqlQuery, (err, result) => {
    if (err) {
      res.status(500).send({ error: 'Error fetching data' });
    } else {
      res.status(200).send(result);
    }
  });
  
});

app.get('/search', verifyToken, (req, res) => {
  let {displayData,searchData}=req.query;
  if (!displayData.trim()  || !searchData.trim() ) {
    res.status(400).send({ error: 'Invalid or missing Parameter' });
    return;
  }
  let sqlQuery;
  if (displayData === "BED") {
    sqlQuery ="SELECT * FROM `furniture_available` WHERE `Category ID`=?";
  } 
  else if (displayData === "beds") {
    searchData=searchData+"%";
    sqlQuery="SELECT * FROM `furniture_available` where Name like ?";
  } else if (displayData === "CABINET") {
    sqlQuery = "SELECT * FROM `furniture_available` WHERE `Category ID`=?";
   } 
  else if (displayData === "cabinets") {
    searchData=searchData+"%";
    sqlQuery = "SELECT * FROM `furniture_available` where Name like ?";
   } 
  else if (displayData === "CHAIR") {
    sqlQuery = "SELECT * FROM `furniture_available` WHERE `Category ID`=?";
   } 
  else if (displayData === "chairs") {
    searchData=searchData+"%";
    sqlQuery = "SELECT * FROM `furniture_available` where Name like ?";
   } 
  else if (displayData === "order") {
    searchData=searchData+"%";
    sqlQuery = "SELECT * FROM `order_detail` WHERE `Order ID like ?";
  } 
  else if (displayData === "SOFA") {
    sqlQuery = "SELECT * FROM `furniture_available` WHERE `Category ID`=?";
   }
  else if (displayData === "Sofas") {
    searchData=searchData+"%";
    sqlQuery = "SELECT * FROM `furniture_available` where Name like ?";
   } 
  else if (displayData === "TABLE") {
    sqlQuery = "SELECT * FROM `furniture_available` WHERE `Category ID`=?";
   }
  else if (displayData === "Tables") {
    searchData=searchData+"%";
    sqlQuery = "SELECT * FROM `furniture_available` where Name like ?";
   }
  else {
    return res.status(400).send({ error: 'Invalid displayData value' });
  }
  db.query(sqlQuery,[searchData], (err, result) => {
    if (err) {
      res.status(500).send({ error: 'Error fetching data' });
    } else {
      res.status(200).send(result);
    }
  });
});


app.put('/furniture', verifyToken, (req, res) => {
  const id=req.query.id;
  const query = "UPDATE `order_detail` SET `Status`='Paid' WHERE `Order ID`=?";
  db.query(query, [id], (err, result) => {
    if (err) {
      res.status(500).send({ error: 'Error' });
    } else {
      res.status(200).send({ message: 'Successfully updated' });
    }
  });
});


app.post('/furniture', verifyToken, (req, res) => {
  const tableName=req.query.tableName;
  console.log(tableName);
  if(tableName==="customer_info"){
    const {CustomerID,Name,Address,PhoneNumber} = req.query;
    console.log(req.query);
    if ( !CustomerID || !Name || !Address || !PhoneNumber ) {
      res.status(400).send({ error: "Missing parameter" });
      return;
    }
    const query = "INSERT INTO `customer_info`(`Customer ID`, `Customer Name`, `Address`, `Phone Number`) VALUES (?,?,?,?)";
    db.query(query, [CustomerID,Name,Address,PhoneNumber], (err, result) => {
      if (err) {
        res.status(500).send({ error: 'Error' });
      } else {
        res.status(200).send({ message: 'Successfully inserted' });
      }
    });
  }
  else if(tableName==="order_detail"){
    const {CustomerID,FurnitureID,Quantity,Price,Subtotal,Order_Date} = req.query;
    console.log(req.query);
    if (!CustomerID || !FurnitureID || !Quantity || !Price|| !Subtotal )  {
      res.status(400).send({ error: "Missing parameter" });
      return;
    }
    const query = "INSERT INTO `order_detail`(` Customer ID`, `Furniture ID`, `Quantity`, `Price`, `Sub-total`, `Order_Date`, `Status`) VALUES (?,?,?,?,?,?,'Unpaid')";
    db.query(query, [CustomerID,FurnitureID,Quantity,Price,Subtotal,Order_Date], (err, result) => {
      if (err) {
        res.status(500).send({ error: 'Error' });
      } else {
        res.status(200).send({ message: 'Successfully inserted' });
      }
    });
  }
  else{
    return res.status(400).send({ error: 'Invalid table name' });
  }
});

app.listen(3000, () => {
  console.log('Server running on port 3000');
});
