using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Indexer
    {
        // <�ε��� ����>
        // this[]�� �Ӽ����� �����Ͽ� Ŭ������ �ν��Ͻ��� �ε��� ������� ���� ���
        public class IndexerArray
        {
            private int[] array = new int[10];

            public int this[int index]
            {
                get
                {
                    if (index < 0 || index >= array.Length)
                        throw new IndexOutOfRangeException();
                    else
                        return array[index];
                }
                set
                {
                    if (index < 0 || index >= array.Length)
                        throw new IndexOutOfRangeException();
                    else
                        array[index] = value;
                }
            }
        }

        void Main1()
        {
            IndexerArray array = new IndexerArray();

            // �ε����� ���� �ε��� ����
            array[5] = 20;      // this[] set ����
            int i = array[5];   // this[] get ����
        }


        // <�ε��� �ڷ���>
        // �ε����� �ٸ� �ڷ��� ��뵵 ����
        // �������� ���� �ε����� ����ϴ� ��쵵 ���
        public enum Parts { Head, Body, Feet, Hand, SIZE }
        public class Equipment
        {
            string[] parts = new string[(int)Parts.SIZE];

            public string this[Parts type]
            {
                get
                {
                    return parts[(int)type];
                }
                set
                {
                    parts[(int)type] = value;
                }
            }
        }

        void Main2()
        {
            Equipment equipment = new Equipment();

            equipment[Parts.Head] = "���� ���";
            equipment[Parts.Feet] = "���� ��ȭ";

            Console.WriteLine($"�����ϰ� �ִ� �Ź� : {equipment[Parts.Feet]}");
        }
    }
}