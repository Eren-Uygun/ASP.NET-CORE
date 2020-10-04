using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.SRP.Model;

namespace SOLID_Principles.SRP.Good
{
   public class ProductProcessor
   {
       Logger logger;
       string log;

       public ProductProcessor()
       {
           logger = new Logger();
       }

       public bool AddProduct(Product product)
       {
            StringBuilder sb = new StringBuilder();

            try
            {
               
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

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\ProductDataLog.txt",log);

                return true;

            }
            catch (Exception e)
            {
                log = logger.BuildLog("Hata Mesajı : "+e.Message);
                logger.LogFile(@"C:\Log.txt", log);

                return false;
            }
       }
   }

 
}
