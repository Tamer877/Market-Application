using Market_Application.dao;
using Market_Application.enumeration;
using Market_Application.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Application.controller
{
    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();  
        }

        public User login(string userName,string password)
        {
            User user = null;
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                user = repository.login(userName, password);
                return user;
            }
            else
            {
                user.status = loginStatus.LackOfParameter;
                return user;
            }
        }

        public List<LoginTable> GetLoginTable()
        {
            List<LoginTable> loginTableList = repository.GetLoginTable();
            return loginTableList;
        }

        public loginStatus doAuthentication(string userName,string securityQuestion,string securityAnswer)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(securityQuestion) && !string.IsNullOrEmpty(securityAnswer))
            {
                loginStatus result = repository.doAuthentication(userName, securityQuestion, securityAnswer);
                return result;
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }

        public loginStatus changePassword(string userName,string password)
        {
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                return repository.changePassword(userName, password);
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }

        public string IsEmailCorrect(string userName)
        {
            return repository.IsEmailCorrect(userName);
        }

        public Product GetProduct(string barcode)
        {
            if (!string.IsNullOrEmpty(barcode))
            {
                return repository.GetProduct(barcode);
            }
            return null;
        }

        public loginStatus addUser(User user)
        {
            if (!string.IsNullOrEmpty(user.userName) && !string.IsNullOrEmpty(user.password) && !string.IsNullOrEmpty(user.authority) && !string.IsNullOrEmpty(user.email))
            {
                loginStatus result = repository.addUser(user);
                return result;
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }
        public loginStatus updateUser(User user)
        {
            return repository.updateUser(user);
        }

        public loginStatus deleteUser(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.deleteUser(int.Parse(id));
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }
        public List<Product> getAllProducts() 
        {
            return repository.getAllProducts(); 
        }

        public loginStatus addProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.id.ToString()) && !string.IsNullOrEmpty(product.productName) && !string.IsNullOrEmpty(product.barkodCode))
            {
                return repository.addProduct(product);
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }

        public ArrayList getProductNames() { return repository.getProductNames(); }

        public loginStatus updateProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.id.ToString()) && !string.IsNullOrEmpty(product.productName) && !string.IsNullOrEmpty(product.barkodCode))
            {
                return repository.updateProduct(product);
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }

        public loginStatus deleteProduct(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.deleteProduct(int.Parse(id));
            }
            else
            {
                return loginStatus.LackOfParameter;
            }
        }
    }
}
