using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Generic
    {
        /**************************************************************************
         * �Ϲ�ȭ ��������Ʈ
         * 
         * ���߰������� ���� ���Ǵ� ��������Ʈ�� ��� �Ϲ�ȭ�� ��������Ʈ�� ���
         **************************************************************************/

        // <Func ��������Ʈ>
        // ��ȯ���� �Ű������� ������ ��������Ʈ
        // Func<�Ű�����1, �Ű�����2, ..., ��ȯ��>
        int Plus(int left, int right) { return left + right; }
        int Minus(int left, int right) { return left - right; }

        void Main1()
        {
            Func<int, int, int> func;
            func = Plus;
            func = Minus;
        }


        // <Action ��������Ʈ>
        // ��ȯ���� void �̸� �Ű������� ������ ��������Ʈ
        // Action<�Ű�����1, �Ű�����2, ...>
        void Message(string message) { Console.WriteLine(message); }

        void Main2()
        {
            Action<string> action;
            action = Message;
        }


        // <Predicate ��������Ʈ>
        // ��ȯ���� bool, �Ű������� �ϳ��� ��������Ʈ
        bool IsSentence(string str) { return str.Contains(' '); }

        void Main3()
        {
            Predicate<string> predicate;
            predicate = IsSentence;
        }
    }
}