using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SOLID_Principles.SRP.Model;

namespace SOLID_Principles.SRP.Bad
{
   public class ProductProcessor
    {

        public void AddProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();

            try
            {

                //Product classının ekleme işlemi

                sb.Append(product.ID);
                sb.AppendLine(); 
                sb.Append(product.ProductName);
                sb.AppendLine();
                sb.Append(product.QuantityPerUnit);
                sb.AppendLine();
                sb.Append(product.UnitPrice);
                sb.AppendLine();
                sb.Append(product.QuantityPerUnit);
                sb.AppendLine();
                sb.Append(product.ProductAddDate);
                sb.AppendLine();
                sb.Append(product.ProductExpireDate);
                sb.AppendLine();
                sb.Append(product.ReorderLevel);
                sb.AppendLine();
                sb.Append(product.Discontinued);
                File.WriteAllText(@"C:\ProductDataLog.txt",sb.ToString());

                //Product Eklenme ile ilgili kayıtların tutulma işlemi

                sb = new StringBuilder();
                sb.Append("Kayıt eklenme tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Ekleyen Personelin Id'si: ");
                sb.Append(product.ID);
                File.WriteAllText(@"C:\Log.txt",sb.ToString());
            }
            catch (Exception e)
            {

                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı: ");
                sb.Append(e.Message);
                File.WriteAllText(@"C:\Log.txt",sb.ToString());
                Console.WriteLine();


            }

        }

    }
}
