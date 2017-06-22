using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment10.Repostitories
{
    public class DataOperations 
    { 
    private string ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-Assignment10-20170622103531;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\BankDB.mdf";
    public bool GetAllCustomers() 
    { 
        using (SqlConnection cn = new SqlConnection() { ConnectionString = ConnectionString }) 
        { 
            try 
            { 
                cn.Open(); 
                return true; 
            } 
            catch (Exception ex) 
            { 
                return false; 
            } 
        } 
    } 
    } 
}

