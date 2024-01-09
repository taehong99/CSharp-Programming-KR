using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Chain
    {
        /***************************************************
         * ��������Ʈ ü��
         * 
         * ��������Ʈ ������ �������� �Լ��� �����ϴ� ���
         ***************************************************/

        // <��������Ʈ ü��>
        // �ϳ��� ��������Ʈ ������ ���� ���� �Լ��� �Ҵ��ϴ� ���� ����
        // +=, -= �����ڸ� ���� �Ҵ��� �߰��ϰ� ������ �� ����
        // = �����ڸ� ���� �Ҵ��� ��� ������ �ٸ� �Լ����� �Ҵ��� ��Ȳ�� �����
        void Main()
        {
            Action action;
            action = Func2;     // ��������Ʈ �ν��Ͻ��� Func2 �� �ʱ�ȭ
            action += Func1;    // ��������Ʈ �ν��Ͻ��� Func1 �߰� ����
            action += Func3;    // ��������Ʈ �ν��Ͻ��� Func3 �߰� ����
            action();           // Func2, Func1, Func3 �� ȣ���

            action -= Func1;    // ��������Ʈ �ν��Ͻ��� Func1 ���� ����
            if (action != null) // ��������Ʈ �ν��Ͻ����� ������ ������ ��� �����ϰ� �ִ� �Լ��� ���� ��츦 ����
                action();       // Func2, Func3 �� ȣ���

            action += Func2;    // ���� �Լ��� ������ ������ ��� ������ ȣ���
            action += Func2;
            action();           // Func2 3ȸ, Func3 1ȸ ȣ���

            action -= Func1;    // ��������Ʈ �ν��Ͻ��� �������� ���� �Լ��� �����ϴ� ��� �ش� �۾��� ���õ�

            action = Func1;     // ��������Ʈ �ν��Ͻ��� = �� ���� �Ҵ��� ��� ������ ������ ��Ȳ�� �����
            action();           // Func1 �� ȣ���
        }

        void Func1() { Console.WriteLine("Func1"); }
        void Func2() { Console.WriteLine("Func2"); }
        void Func3() { Console.WriteLine("Func3"); }
    }
}