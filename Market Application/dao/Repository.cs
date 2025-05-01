using Market_Application.enumeration;
using Market_Application.model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = Market_Application.model.User;

namespace Market_Application.dao
{
   public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> loginTableList;

        public Repository()
        {
            con = new SqlConnection("Data Source=TAMER;Initial Catalog=market;Persist Security Info=True;User ID=sa;Password=1;Encrypt=False");
        }

        public User login(string userName,string password)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where userName=@userName and passwordd=@passwordd", con);

            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@passwordd", password);
            dr = cmd.ExecuteReader();
            

            if (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"].ToString());
                string authority = dr["authority"].ToString();
                string email = dr["email"].ToString();
                string securityQuestion = dr["securityQuestion"].ToString();
                string securityAnswer = dr["securityAnswer"].ToString();
                loginStatus status = loginStatus.Success;

                User user = new User(id,userName,password,authority,email,securityQuestion,securityAnswer,status);
                con.Close();
                return user;
            }
            else
            {
                User user = new User();
                user.status = loginStatus.Unsuccess;
                return user;
            }
        }

        public List<LoginTable> GetLoginTable()
        {
            loginTableList = new List<LoginTable>();
            con.Open();
            cmd = new SqlCommand("getSecurityQuestion_sp",con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LoginTable loginTable = new LoginTable();
                loginTable.id = Convert.ToInt32(dr["id"].ToString());
                loginTable.userName = dr["userName"].ToString();
                loginTable.region = dr["region"].ToString();
                loginTable.password = dr["passwordd"].ToString();
                loginTable.authority = dr["authority"].ToString();
                loginTable.email = dr["email"].ToString();
                loginTable.securityQuestion = dr["securityQuestion"].ToString();
                loginTable.securityAnswer = dr["securityAnswer"].ToString();
                loginTableList.Add(loginTable);
            }
            con.Close();

            return loginTableList;
        }

        public loginStatus doAuthentication(string userName,string securityQuestion,string securityAnswer)
        {
            con.Open();
            cmd = new SqlCommand("select count (*) from loginTable where userName=@userName and securityQuestion=@securityQuestion and securityAnswer=@securityAnswer", con);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();

            if (returnvalue == 1)
                return loginStatus.Success;
            else
                return loginStatus.Unsuccess;
        }

        public loginStatus changePassword(string userName,string password)
        {
            con.Open();
            cmd = new SqlCommand("passwordUpdate_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            con.Close();
            return loginStatus.Success;
        }
        public string IsEmailCorrect(string userName)
        {
            con.Open();
            cmd = new SqlCommand("select email from loginTable Where userName=@userName",con);
            cmd.Parameters.AddWithValue("@userName", userName);
            string email = cmd.ExecuteScalar().ToString();
            con.Close();
            return email;
        }

        public Product GetProduct(string barcode)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Table_Product where barkodCode=@barcode", con);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            dr = cmd.ExecuteReader();
            Product product = new Product();
            dr.Read();
            
            product.id =int.Parse(dr["id"].ToString());
            product.qrCode = dr["qrCode"].ToString();
            product.barkodCode = dr["barkodCode"].ToString();
            product.productName = dr["productName"].ToString();
            product.weight = int.Parse(dr["weightt"].ToString());
            product.price = int.Parse(dr["price"].ToString());
            
            dr.Close();
            con.Close();

            return product;
        }

        public loginStatus addUser(User user)
        {
            con.Open();
            cmd = new SqlCommand("spAddUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userName", user.userName);
            cmd.Parameters.AddWithValue("@region", user.region);
            cmd.Parameters.AddWithValue("@passwordd", user.password);
            cmd.Parameters.AddWithValue("@authority", user.authority);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", user.securityAnswer);

            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
                return loginStatus.Success;
            else
                return loginStatus.Unsuccess;
        }

        public loginStatus updateUser(User user)
        {
            con.Open();
            cmd = new SqlCommand("spUpdateUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@userName", user.userName);
            cmd.Parameters.AddWithValue("@region", user.region);
            cmd.Parameters.AddWithValue("@passwordd", user.password);
            cmd.Parameters.AddWithValue("@authority", user.authority);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", user.securityAnswer);

            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
                return loginStatus.Success;
            else
                return loginStatus.Unsuccess;
        }
        public loginStatus deleteUser(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue==1)
            {
                return loginStatus.Success;
            }
            else
            {
                return loginStatus.Unsuccess;
            }
        }

        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            con.Open();
            cmd = new SqlCommand("select * from Table_Product",con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Product product = new Product();
                product.id = int.Parse(dr["id"].ToString());
                product.qrCode = dr["qrCode"].ToString();
                product.barkodCode = dr["barkodCode"].ToString();
                product.creationDate = DateTime.Parse(dr["creationDate"].ToString());
                if (!string.IsNullOrEmpty(dr["updateDate"].ToString()))
                    product.updateDate = DateTime.Parse(dr["updateDate"].ToString());
                product.productName = dr["productName"].ToString();
                product.weight = int.Parse(dr["weightt"].ToString());
                product.price = int.Parse(dr["price"].ToString());
                product.turnover = int.Parse(dr["turnover"].ToString());
                products.Add(product);

            }
            con.Close();
            return products;
        }

        public loginStatus addProduct(Product product)
        {
            con.Open();
            cmd = new SqlCommand("sp_AddProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", product.id);
            cmd.Parameters.AddWithValue("@qrCode", product.qrCode);
            cmd.Parameters.AddWithValue("@barkodCode", product.barkodCode);
            cmd.Parameters.AddWithValue("@creationDate", product.creationDate);
            cmd.Parameters.AddWithValue("@updateDate", product.updateDate);
            cmd.Parameters.AddWithValue("@productName", product.productName);
            cmd.Parameters.AddWithValue("@weightt", product.weight);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@turnover", product.turnover);

            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
                return loginStatus.Success;
            else
                return loginStatus.Unsuccess;
        }

        public ArrayList getProductNames()
        {
            con.Open();
            cmd = new SqlCommand("Select productName from Table_Product", con);
            dr = cmd.ExecuteReader();

            ArrayList productNames = new ArrayList();
            
            while (dr.Read())
            {
                productNames.Add(dr["productName"].ToString());
            }
            con.Close();
            return productNames;
        }

        public loginStatus updateProduct(Product product)
        {
            con.Open();
            cmd = new SqlCommand("spUpdateProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", product.id);
            cmd.Parameters.AddWithValue("@qrCode", product.qrCode);
            cmd.Parameters.AddWithValue("@barkodCode", product.barkodCode);
            cmd.Parameters.AddWithValue("@creationDate", product.creationDate);
            cmd.Parameters.AddWithValue("@updateDate", product.updateDate);
            cmd.Parameters.AddWithValue("@productName", product.productName);
            cmd.Parameters.AddWithValue("@weightt", product.weight);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@turnover", product.turnover);

            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
                return loginStatus.Success;
            else
                return loginStatus.Unsuccess;
        }

        public loginStatus deleteProduct(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from Table_Product where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
            {
                return loginStatus.Success;
            }
            else
            {
                return loginStatus.Unsuccess;
            }
        }




    }
}
