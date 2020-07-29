using Jint.Parser.Ast;
using MySql.Data.MySqlClient.Memcached;
using Renci.SshNet;
using SolrNet.Utils;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace SSHconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (var sw = new StreamWriter(args[0]))
            {
                sw.WriteLine("Welcome to Windows service in .net");
            }
            Console.ReadKey();

            {
                //Connection information
                Console.WriteLine("Welcome to CMD SSH! I need correct login information and port 22 SSH protocol to be allowed by the firewall to work. Program C 2020 keifmeister.");
                Console.WriteLine("");
                Console.WriteLine("Enter username to be logged into:");
                string username = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter user password.");
                string password = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter IP address for SSH connection.");
                string ipaddr = Convert.ToString(Console.ReadLine());

                {
                    // insert stuff here

                    {
                        /* everything inside the `while` loop will be 
                           repeated until `continue` is not `true`. */
                    }
                    Console.WriteLine("Run another command? Type anything besides no to run a command, or type no to exit.");
                    string ranother = Convert.ToString(Console.ReadLine());
                    while (ranother != "no")
                    {
                        Console.WriteLine("Enter command to be run.");
                        string rcommand = Convert.ToString(Console.ReadLine());

                        string user = username;
                        string pass = password;
                        string host = ipaddr;



                        //Set up the SSH connection
                        using (var client = new SshClient(host, user, pass))

                            try
                            {
                                //Start the connection

                                client.Connect();

                                var output = client.RunCommand(rcommand);

                                Console.WriteLine(output.Result);
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine("It looks like I couldn't make a connection. Possible reasons for this include: login information (password, username, or ip address) was entered incorrectly. Please double check. Other reasons: The server connecting to is not configured for SSH or I am blocked by a firewall. Cheers");



                            }
                    }

                }
            }

        }
    }
}