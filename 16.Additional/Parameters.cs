using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Parameter
    {
        // <Named Parameter>
        // �Լ��� �Ű����� ������ �����ϰ� �̸��� ���� ȣ��
        void Profile(int id, string name, string phone) { }

        void Main1()
        {
            // �Լ� ȣ��� �̸��� ����ϰ� ������ ������� ȣ�� ����
            Profile(phone: "010-1111-2222", id: 1, name: "ȫ�浿");
            Profile(name: "ȫ�漭", phone: "010-1234-5678", id: 2);
        }


        // <Optional Parameter>
        // �Լ��� �Ű������� �ʱⰪ�� ���� �ִٸ�, �Լ� ȣ��� �����ϴ� ���� ����ϴ� ���
        void AddStudent(string name, string home = "����", int age = 8) { }   // �ʱⰪ�� �ִ� ��� �̸� �Ҵ�
        // void AddStudent(int age = 8, string home = "����", string name) {} // error : �ʱⰪ�� �ִ� �Ű������� �ں��� ��ġ�ؾ���

        void Main2()
        {
            AddStudent("ö��");               // AddStudent("ö��", "����", 8);
            AddStudent("����");               // AddStudent("����", "����", 8);
            AddStudent("����", "��õ");       // AddStudent("����", "��õ", 8);
            AddStudent("�̿�", age: 7);       // AddStudent("�̿�", "����", 7);
        }


        // <Params Parameter>
        // �Ű������� ������ �������� ���� ���, �Ű������� ������ ���������� ����ϴ� ���
        int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) sum += values[i];
            return sum;
        }

        void Main3()
        {
            Sum(1, 3, 5, 7, 9);
            Sum(3, 5, 7);
            Sum();
        }


        // <in Parameter>
        // �Ű������� �Է��������� ����
        // �Լ��� ó������ ������ ������ ���� �����ϰ� ��
        int Plus(in int left, in int right)
        {
            // left = 20;      // error : �Է����� �Ű������� ���� �Ұ�
            return left + right;
        }

        void Main4()
        {
            int result = Plus(1, 3);
            Console.WriteLine($"{result}");     // output : 4
        }


        // <out Parameter>
        // �Ű������� ����������� ����
        // �Լ��� ��ȯ�� �ܿ� �߰����� ����� �ʿ��� ��� ���
        void Divide(int left, int right, out int quotient, out int remainder)
        {
            quotient = left / right;
            remainder = left % right;

            // �Լ��� ���������� out �Ű������� ���� �Ҵ� �ȵǴ� ��� ����
        }

        void Main5()
        {
            int quotient;
            Divide(5, 3, out quotient, out int remainder);
            Console.WriteLine($"{quotient}, {remainder}");  // output : 1, 2
        }


        // <ref Parameter>
        // �Ű������� ���������� ����
        // �Ű������� �������� ��쿡�� �Լ��� ���� �������� �����ϰ� ���� ��� ���
        void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        void Main6()
        {
            int left = 10;
            int right = 20;
            Swap(ref left, ref right);
            Console.WriteLine($"{left}, {right}");      // output : 20, 10
        }
    }
}