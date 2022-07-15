using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    /// <summary>
    /// Динамический массив.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T> : IEnumerable<T>
    {
        T[] array;
        int count = 0;
        public const int defaultCapacity = 8;

        #region Конструкторы

        /// <summary>
        ///  Создает массив на 8 элементов.
        /// </summary>
        public DynamicArray()
            : this(defaultCapacity)
        {

        }

        /// <summary>
        /// Создает массив на {count} элементов.
        /// </summary>
        /// <param name="count"></param>
        public DynamicArray(int count)
        {
            array = new T[count];
        }

        /// <summary>
        /// Создает массив основываясь на коллекции.
        /// </summary>
        /// <param name="collection"></param>
        public DynamicArray(IEnumerable<T> collection)
        {
            array = new T[collection.Count()];
            for (int i = 0; i < collection.Count(); i++)
            {
                array[i] = collection.ElementAt(i);
                count++;
            }
        }

        #endregion Конструкторы

        #region Методы

        /// <summary>
        /// Добавление элемента в массив.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            AddRange(new T[] { element });
        }

        /// <summary>
        /// Добавление коллекции элементов в массив.
        /// </summary>
        /// <param name="collection"></param>
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection is null)     // Валидация.
            {
                throw new ArgumentNullException("Пустая коллекция!");
            }
            count = Length;

            var a = count + collection.Count();
            var newArrayT = new T[1];

            if (a <= array.Length)
            {
                newArrayT = new T[array.Length];
            }
            else
            {
                newArrayT = new T[count + collection.Count()];
            }

            array.CopyTo(newArrayT, 0);

            int num = 0;

            for (int i = count; i < collection.Count(); i++)
            {
                newArrayT[i] = collection.ElementAt(num);
                num++;
            }
            array = newArrayT;
            count = array.Length;
        }

        /// <summary>
        /// Удаление указанного элемента массива.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Remove(T element)
        {
            if (element is null)    // Валидация.
            {
                throw new ArgumentNullException("Элемент должен быть не пустым!");
            }

            int numElements = 0;
            for (int i = 0; i < count; i++)     // Подсчитываем количество одинаковых элементов
            {
                if (element.Equals(GetElement(i)))
                {
                    numElements++;
                }
            }

            if (numElements != 0)
            {
                RemoveElement(element);     // Вызываем метод удаления элемента
                return true;
            }
            else return false;
        }

        /// <summary>
        /// добавление элемента в любую точку массива.
        /// </summary>
        /// <param name="element"> добавляемый элемент</param>
        /// <param name="position">позиция элемента в массиве</param>
        /// <returns></returns>
        public bool Insert(T element, int position)
        {
            if (element is null)    // валидация
            {
                throw new ArgumentNullException("Элемент пустой!");
            }

            if (position > Capacity)  // Валидация.
            {
                throw new ArgumentOutOfRangeException("Позиция за пределами массива!");
            }

            if (position > Length)
            {
                array[position] = element;
                return true;
            }

            if (position <= Length)
            {
                if (Length < Capacity)
                {
                    InsertIn(element, position, array.Count());
                    return true;
                }

                if (Length == Capacity)
                {
                    InsertIn(element, position, array.Count() + 1);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Вспомогательный метод для добавления элемента в массив.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="position"></param>
        /// <param name="num"></param>
        private void InsertIn(T element, int position, int num)
        {
            var newArrayT = new T[num];
            for (int i = 0; i < position - 1; i++)
            {
                newArrayT[i] = array[i];
            }
            newArrayT[position - 1] = element;
            int n = position - 1;
            for (int i = position; i < newArrayT.Count(); i++)
            {
                newArrayT[i] = array[n];
                n++;
            }
            array = newArrayT;
        }

        /// <summary>
        ///  Доп метод для удаления элементов массива.
        /// </summary>
        /// <param name="element"></param>
        private void RemoveElement(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (element.Equals(GetElement(i)))
                {
                    var list = array.ToList();
                    array = new T[Capacity];

                    list.CopyTo(0, array, 0, i);
                    list.CopyTo(i + 1, array, i + 1, count - i - 1);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion Методы

        #region Parameters

        /// <summary>
        /// Индексатор. Обращение к элементу массива.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get {
                if (index>=0 && index<Capacity)
                {
                    return array[index];
                }
                else throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
            }
            set
            {
                if (index >= 0 && index < Capacity)
                {
                     array[index]=value;
                }
            }
        }

        /// <summary>
        /// Емкость массива.
        /// </summary>
        public int Capacity    
        {
            get { return array.Length; }
        }
        
        /// <summary>
        /// Количество заполненных элементов.
        /// </summary>
        public int Length       
        {
            get { return count; }
        }
        
        /// <summary>
        /// получить  элемент массива.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetElement(int index)  
        {
            return array[index];
        }

        #endregion Parameters
    }
}
