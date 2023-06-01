using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace FinalProject
{
    class InfoDB
    {
        public static void dgvViewing(string displayData, DataGridView dgv)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("furniture", Method.GET);
                request.AddHeader("authorization", InfoStorage.infoSet.token);
                request.AddParameter("displayData", displayData);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {

                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(response.Content);
                    dgv.DataSource = dt;
                    dgv.Columns[0].Visible = false;

                }
                else
                {
                    MessageBox.Show("Error fetching data");
                }
            }
            catch
            {
            }
        }
        public static void dgvViewing(string displayData, string searchData, DataGridView dgv)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("search", Method.GET);
                request.AddHeader("authorization", InfoStorage.infoSet.token);
                request.AddParameter("displayData", displayData);
                request.AddParameter("searchData", searchData);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(response.Content);
                    dgv.DataSource = dt;
                    dgv.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Error fetching data");
                }
            }
            catch
            {

            }
        }
        public static void saveData(string tableName, string[] columnName, string[] data)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("furniture", Method.POST);
                request.AddHeader("authorization", InfoStorage.infoSet.token);

                request.AddQueryParameter("tableName", tableName);
                for (int i = 0; i < data.Length; i++)
                {
                    request.AddQueryParameter(columnName[i], data[i]);
                }
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {

                }
                else
                {
                    MessageBox.Show("Fill up incomplete" + response.ErrorMessage);
                }
            }
            catch
            {
            }
        }
        public static void updateData( int id)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("furniture", Method.PUT);
                request.AddHeader("authorization", InfoStorage.infoSet.token);

                request.AddQueryParameter("id", id.ToString());
               
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {

                }
                else
                {
                    MessageBox.Show("Fill up incomplete!!" + response.ErrorMessage);
                }
            }
            catch
            {
            }
        }
        public static void createAccount( string[] columnName, string[] data)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("create-account", Method.POST);
                for (int i = 0; i < data.Length; i++)
                {
                    request.AddQueryParameter(columnName[i], data[i]);
                }
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {

                }
                else
                {
                    MessageBox.Show("Fill up incomplete" + response.ErrorMessage);
                }
            }
            catch
            {
            }
        }
        public static bool GetAdminPassword(TextBox username, TextBox password)
        {
            bool verify = false;
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("login", Method.POST);
                request.AddQueryParameter("username", username.Text);
                request.AddQueryParameter("password", password.Text);

                var response = client.Execute(request);
                if (response.ContentLength > 2)
                {
                    JArray jsonArray = JArray.Parse(response.Content);
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonArray.ToString());
                    verify = true;
                    InfoStorage.infoSet.token = (dt.Rows[0]["Token"]).ToString();
                }
            }
            catch
            {
            }
            return verify;
        }
        public static void getMax()
        {
            try
            {
                RestClient client = new RestClient("http://localhost:3000");
                var request = new RestRequest("furniture", Method.GET);
                request.AddHeader("authorization", InfoStorage.infoSet.token);
                request.AddParameter("displayData", "MaxID");
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    JArray jsonArray = JArray.Parse(response.Content);
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonArray.ToString());
                    int idnum = int.Parse((dt.Rows[0]["maxID"]).ToString());
                    InfoStorage.infoSet.maxId = idnum + 1;
                }
                else
                {
                    MessageBox.Show("Error fetching data");
                }
            }
            catch
            {
            }
        }
    }
}