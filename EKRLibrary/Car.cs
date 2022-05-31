using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    /// <summary>
    /// Класс машины, наследуемый от базового (Transport).
    /// </summary>
    public class Car : Transport
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public Car(string model, uint power) : base(model, power)
        {

        }
        /// <summary>
        /// Метод звука Врум.
        /// </summary>
        /// <returns></returns>
        public override string StartEngine()
        {
            return ($"{Model}:Vroom");
        }
        /// <summary>
        /// //Переопределенный метод ToString(), приписывает слева строку "Car. ".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"Car. Model: { Model}, Power: { Power}");
        }

    }
}
