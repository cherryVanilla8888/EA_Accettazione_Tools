using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EA_Dashboard.Data
{
    public class DataService
    {
        private string connectionString;
        public DataService()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["MyDBName"].ConnectionString;
        }

        #region Getters Methods
        //internal List<Customer> getCustomers()
        //{
        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        return db.Query<Customer>("Select * From dbo.Clienti").ToList();
        //    }
        //}

        #endregion

        #region Insert Methods
        //internal void insertNewCliente(Customer cliente)
        //{
        //    string sql = @"INSERT INTO dbo.Clienti(Nominativo, Indirizzo, Citta, Provincia, CAP, PartitaIva,
        //                                         CodiceFiscale, Referente,Email)
        //                            Values (@Nominativo, @Indirizzo, @Citta, @Provincia, @CAP, @PartitaIva, 
        //                                    @CodiceFiscale, @Referente, @Email);";

        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        var result = db.Execute(sql, cliente);
        //    }
        //}
        #endregion

        #region Update Methods
        //internal void updateCliente(Customer customer, string field)
        //{
        //    string sql = $"UPDATE dbo.Clienti SET {field} = @{field} WHERE Id = {customer.Id};";

        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        var result = db.Execute(sql, customer);
        //    }
        //}
        #endregion


    }
}