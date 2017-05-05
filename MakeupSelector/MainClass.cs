using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MakeupSelector
{
    class MainClass
    {
        List<MakeupProduct> data = new List<MakeupProduct>();
        SQLiteConnection db = new SQLiteConnection("makeupdb");

        public List<MakeupProduct> getData(String category)
        {
            String linkCategory = "http://makeup-api.herokuapp.com/api/v1/products.json?product_type=" + category;
            Console.WriteLine(linkCategory);        
           
            var httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync(linkCategory).Result;
            response.EnsureSuccessStatusCode();
            string resultAsString = response.Content.ReadAsStringAsync().Result;

            List<MakeupProduct> productData = JsonConvert.DeserializeObject<List<MakeupProduct>>(resultAsString);
            Trace.WriteLine(resultAsString);

            return productData;
        }

        public void saveBrand(String brand)
        {
            
            db.CreateTable<MakeupProduct>();
            db.DeleteAll<MakeupProduct>();

            var data = getData(brand);

            Trace.WriteLine(data.Count);

            foreach (MakeupProduct makeupProduct in data)
            {
                if (makeupProduct.brand.Equals(brand))
                {
                    db.Insert(makeupProduct);
                }
            }
        }

        public List<MakeupProduct> getMakeupProduct(){
            List<MakeupProduct> semuaMakeup = db.Table<MakeupProduct>().ToList();
            return semuaMakeup;

            
        }
    }
}
