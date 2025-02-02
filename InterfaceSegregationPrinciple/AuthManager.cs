using System;

namespace InterfaceSegregation;

public class AuthManager
{
    public void Login()
    {
        //Logging in the user
    }
    public void Logout()
    {
        //Logging out the user 
    }

    public Boolean IsCurrentUserAuthenticated()
    {
        //whether the current user is authenticated or not 
        return true;
    }

    public Employee GetCurrentLoggedInUser()
    {
        //get the current logged in user details
        return new Employee();
    }
}