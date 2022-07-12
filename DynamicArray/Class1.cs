using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        T[] arrayT;
        int count = 0;

        /// <summary>
        ///  Создает массив на 8 элементов.
        /// </summary>
        public void CreateArray()
        {
            arrayT = new T[8];
        }

        public void CreateArray(int num)
        {
            arrayT = new T[num];
        }

        public void CreateArray(IEnumerable<T> col)
        {
            arrayT = new T[col.Count()];
            for (int i = 0; i < col.Count(); i++)
            {
                arrayT[i] = col.ElementAt(i);
                count++;
            }
        }

        public void Add(T element)
        {
            if (Length == Capacity - 1)
            {
                var newArrayT = new T[Capacity * 2];
                for (int i = 0; i < Capacity; i++)
                {
                    newArrayT[i] = arrayT[i];
                }
                arrayT = newArrayT;
            }
            arrayT[count] = element;
            count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            count = Length;
            var newArrayT = new T[count + collection.Count()];
            arrayT.CopyTo(newArrayT, 0);

            int num = 0;

            for (int i = count; i < newArrayT.Count(); i++)
            {
                newArrayT[i] = collection.ElementAt(num);
                num++;
            }
            arrayT = newArrayT;
            count = arrayT.Length;
        }

        public bool Remove(T element)
        {
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
                RemoveElement(element);     // вызываем метод удаления элемента
                return true;
            }
            else return false;
        }

        public bool Insert(T element, int position)
        {
            try
            {
                if (position < Capacity)
                {
                    if (position > Length)
                    {
                        arrayT[position] = element;
                        return true;
                    }
                    else
                    {
                        var newArrayT = new T[arrayT.Count()];
                        for (int i = 0; i < position - 1; i++)
                        {
                            newArrayT[i] = arrayT[i];
                        }
                        newArrayT[position - 1] = element;
                        int n = position - 1;
                        for (int i = position; i < newArrayT.Count(); i++)
                        {
                            newArrayT[i] = arrayT[n];
                            n++;
                        }

                        return true;
                    }
                } else
                {
                    var newArrayT = new T[position];
                    arrayT.CopyTo(newArrayT, 0);
                    newArrayT[position - 1] = element;

                    arrayT = newArrayT;
                    return true;
                }


            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0;i<Length;i++)
            {
                yield return this.GetElement(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void RemoveElement(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (element.Equals(GetElement(i)))
                {
                    var list = arrayT.ToList();
                    arrayT = new T[Capacity];

                    list.CopyTo(0, arrayT, 0, i);
                    list.CopyTo(i + 1, arrayT, i + 1, count - i - 1);
                }
            }
        }

        public T this[int index]
        {
            get => arrayT[index];
            set => arrayT[index] = value;
        }


        public int Capacity     // Емкость массива.
        {
            get { return arrayT.Length; }
        }
        
        public int Length       // Количество заполненных элементов
        {
            get { return count; }
        }
        
        public T GetElement(int index)      // Получаем элемент массива
        {
            return arrayT[index];
        }
    }
}
