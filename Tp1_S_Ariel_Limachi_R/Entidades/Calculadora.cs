using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador ingresado sea valido, en caso de no serlo retornara + por defecto
        /// </summary>
        /// <param name="op"></param> es el operador 
        /// <returns></returns>
       private static char ValidarOperador(char op)
        {
            char r = '+';
            if (op == '-' || op == '*' || op == '/')
            {
                r = op;
            }
            return r;
        }

        /// <summary>
        /// realiza las operaciones matematicas basicas entre 2 objetos tipo Operando
        /// </summary>
        /// <param name="num1"></param> primer objeto tipo operando
        /// <param name="num2"></param> segundo objeto tipo operando
        /// <param name="operador"></param> es la operacion que se realizara entre los 2 operadores
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2,char operador)
        {
            double r = 0;
            switch (ValidarOperador(operador))
            {
                case '-':
                    r = num1 - num2;
                    break;
                case '*':
                    r = num1 * num2;
                    break;
                case '/':
                    r = num1 / num2;
                    break;
                case '+':
                    r = num1 + num2;
                    break;
            }
            return r;
        }
    }
}
