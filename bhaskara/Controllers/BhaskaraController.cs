using System;
using bhaskara.Models;

namespace bhaskara.Controllers
{
    public class BhaskaraController
    {

        public double CalculaX1(double a, double b, double c)
        {
            try
            {
                double delta = (b*b) - (4 * a * c);
                double x1 = (-b + (Math.Sqrt(delta))) / 2 * a;

                if(delta < 0)
                {
                    return 204;
                }
                else
                {
                    return x1;
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Ops, parece que algo deu errado");
                return 500;
            }
            
        }
        public double CalculaX2(double a, double b, double c)
        {
           try
            {
                double delta = (b*b) - (4 * a * c);
                double x2 = (-b - (Math.Sqrt(delta))) / 2 * a;

                if(delta < 0)
                {
                    return 204;
                }
                else
                {
                    return x2;
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Ops, parece que algo deu errado");
                return 500;
            }
            
        }
    }
 }