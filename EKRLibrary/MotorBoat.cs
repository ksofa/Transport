using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    public class MotorBoat : Transport
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public MotorBoat(string model, uint power) : base(model, power)
        {

        }
        /// <summary>
        /// Метод звука Брбр.
        /// </summary>
        /// <returns></returns>
        public override string StartEngine()
        {
            return ($"{Model}:Brrrbrr");
        }
        /// <summary>
        /// /Переопределенный метод ToString(), приписывает слева строку "MotorBoat. ".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"MotorBoat. Model: { Model}, Power: { Power}");
        }
    }
}
