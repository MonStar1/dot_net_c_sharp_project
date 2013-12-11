using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Criterion;
using System.IO;
using System.Net.Sockets;

namespace ShopCompDotNet
{
    static class AddProduct
    {
        private static ISessionFactory sessions;
        
        public static void Configurete()
        {
            var conf = new Configuration();
            conf.Configure();
            conf.AddClass(typeof(Product));
            try
            {
                sessions = conf.
                    BuildSessionFactory();
            }
            catch (SocketException ex)
            {
                foreach (var data in ex.Data)
                {
                    var s = data;
                }
            }
            
        }

        public static void CreateTables()
        {
           
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddClass(typeof(Product));
            SchemaExport schemaExport = new SchemaExport(configuration);
            schemaExport.Execute(false, true, false);
        }

        public static void InsertProduct(Product prod)
        {
            using (ISession session = sessions.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Save(prod);
                tx.Commit();
               
            }
        }

        public static void UpdateProduct(Product prod)
        {
            using (ISession session = sessions.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Update(prod);
                tx.Commit();
               
            }
        }

        public static void DeleteProduct(Product prod)
        {
            using (ISession session = sessions.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Delete(prod);
                tx.Commit();
                
            }
        }


        public static IList<Product> FindContacts(int Id)
        {
            using (ISession sess = sessions.OpenSession())
            {
                return sess.CreateCriteria(typeof(Product))
                                .List<Product>();
            }
        }
    }
}
