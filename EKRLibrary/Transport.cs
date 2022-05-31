using System;

namespace EKRLib
{
    abstract public class Transport
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="power"></param>
        public Transport(string model, uint power)
        {
            Model = model;
            Power = power;
        }

        //поля.
        private string model;
        private uint power;
        /// <summary>
        ///  Строковое свойство Model (модель).
        /// </summary>
        protected string Model
        {

            set
            {
                //флаг.
                bool flag = true;
                //Проверяю, что состоит из верных букв и цифр.
                foreach (var symbol in value)
                {
                    if (!((symbol >= 'A' && symbol <= 'Z') || (symbol >= '0' && symbol <= '9')))
                    {
                        flag = false;
                        break;
                    }
                }
                //Проверка корректности модели.
                if (value.Length != 5 || flag == false)
                {
                    throw new TransportException($"Недопустимая модель {value}");
                    // исправить на модел и транспорт
                }
                model = value;

            }
            get { return model; }

        }
        /// <summary>
        ///  Целочисленное свойство Power (мощность в лошадиных силах, тип uint).
        /// </summary>
        protected uint Power
        {
            set
            {
                //Проверяю мощность на корректность.
                if (value < 20)
                {
                    throw new TransportException("Мощность не может быть меньше 20 л.с.");
                }
                power = value;
            }
            get { return power; }
        }
        /// <summary>
        /// Переопределенный метод ToString(), возвращающий строку.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"Model:{Model}, Power: {Power}");
        }
        /// <summary>
        ///  Абстрактный метод string StartEngine(), переопределяемый в производных
        /// классах для получения звука(в виде строки), издаваемого транспортным средством
        /// </summary>
        /// <returns></returns>
        public abstract string StartEngine();

    }
}
