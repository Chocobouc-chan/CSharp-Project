﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Project_CSharp.Exceptions.PersException;

namespace Project_CSharp.Authentification
{
    namespace Authentification
    {
        class AuthentificationManager
        {
            // Si on créé une classe User, il suffit de passer en paramètre un User
            // Du coup est-ce qu'il faut créer une classe User ?
            //Ou du coup on créé une instance de User ici et ensuite on fait une liste d'User ? 

            private static List<User> _users = new List<User>();

            
            public void addUser(String login, String password)
            {
                    foreach (User u in _users)
                    {
                    // Pas deux utilisateurs avec le même pseudo ??? 
                    // Si on passe ensuite par des Chatter avec alias on peut laisser deux users avec le meme login
                    // Mais pas deux fois le meme alias lorsqu'il sera dans le chat 

                        if (u.login.Equals(login) && u.password.Equals(password) || u.login.Equals(login))
                        {
                            throw new UserExistsException("already exists !", login);
                        }
                    }

                    User temp = new User(login, password);
                    _users.Add(temp);

                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    Console.WriteLine("{1} has been added !", temp.login, ti.ToTitleCase(temp.login));
            }

            public void removeUser(String login)
            {
                //Du coup si on laisse deux Users avoir le meme login
                //Faut supprimer en sachant le mdp ?
                //Je pense qu'il faut pas leur laisser le même login du coup

                bool flag = false;

                for(int i = 0; i < _users.Count; i++)
                {
                    if (_users[i].login.Equals(login))
                    {

                        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                        Console.WriteLine("{1} has been removed !", _users[i].login, ti.ToTitleCase(_users[i].login));

                        _users.Remove(_users[i]);
                        flag = true; 
                    }
                }

                if(!flag)
                {
                    throw new UserUnknowException("was not found.", login);
                }
            }

            public void checkRegistredUsers()
            {
                Console.WriteLine("Users already registrered : ");

                foreach (User u in _users)
                {
                    Console.WriteLine(u);
                }
            }

            public void authentify(String login, String password)
            {
                if(true)
                {
                    throw new UserExistsException("Authentify method flag, UserExistsException raised", login);
                    throw new WrongPasswordException("Authentify method flag, WrongPasswordException", login);
                }
                else
                {
                    //Authentify
                }
            }

            public static AuthentificationManager load(String path)
            {
                if(true)
                {
                    throw new IOException();
                }
                else
                {
                    //On charge
                }

            }

            public void save(String path)
            {
                if(true)
                {
                    throw new IOException();
                }
                else
                {
                    //Save inside txt file
                }
            }
        }
    }
}
