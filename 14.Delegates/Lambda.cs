using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Lambda
    {
        /*************************************************************************
         * ����޼���� ���ٽ�
         * 
         * ��������Ʈ ������ �Ҵ��ϱ� ���� �Լ��� �ҽ��ڵ� �������� �����Ͽ� ����
         * �����ϱ� ���� �Լ��� �����ϰ� ��ȸ������ ���� ��쿡 �����ϰ� �ۼ�
         *************************************************************************/

        void Main()
        {
            Func<string, int> func;

            // <�Լ��� ���� �Ҵ�>
            // Ŭ������ ���ǵ� �Լ��� ���� �Ҵ�
            // Ŭ������ ����Լ��� �����ϱ� ���� ����� ���� ��� ����
            func = CharCount;


            // <����޼���>
            // �Լ��� ���� ������ �Լ��� ���������� ����Ǿ� �־�� ��� ����
            // �Ҵ��ϱ� ���� �Լ��� �����ϰ� ���� ���ɼ��� ��ȿ����
            // ������ ǥ������ ���� �Լ��� ��� �ۼ��Ͽ� �����ϴ� ���
            func = delegate (string str) { return str.Length; };


            // <���ٽ�>
            // ����޼����� ������ ǥ����
            func = (str) => { return str.Length; };
            func = str => str.Length;
        }

        int CharCount(string str) { return str.Length; }
    }
}