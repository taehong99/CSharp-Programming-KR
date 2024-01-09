using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Interface
{
    internal class Architecture
    {
        /**********************************************************************************
         * �߻�Ŭ������ �������̽�
         * 
         * �������̽��� �߻�Ŭ������ �������� Ư¡�� ������
         * �Լ��� ���� ���� �����ϰ� �̸� �����ϴ� Ŭ�������� ��üȭ�Ͽ� ���
         * ������, �߻�Ŭ������ �������̽��� ���� ��� ȿ���� �ٸ��� �ٸ� ������ ������
         * �����ڴ� �������̽��� �߻�Ŭ���� �� ���� ��Ȳ�� ������ ������ �����ؾ� ��
         *********************************************************************************/

        // <�߻�Ŭ������ �������̽�>
        // ������ : �Լ��� ���� ���� �����ϰ� �̸� �����ϴ� Ŭ�������� ��üȭ�Ͽ� ���
        // ������ : �߻�Ŭ���� - ����, �Լ��� ���� ���� ���� / ���߻�� �Ұ�
        //          �������̽� - ����, �Լ��� ���� ���� �Ұ� / �������� ����

        // �߻�Ŭ���� (A Is B ����)
        // ��� ������ ���, �ڽ�Ŭ������ �θ�Ŭ������ �����з��� ���
        // ����� ���� ���� �� �ִ� ȿ���� ���� �� ����
        // �θ�Ŭ������ ����� ���� �ڽ�Ŭ������ ����� Ȯ���ϴ� ��� ���

        // �������̽� (A Can B ����)
        // �ൿ ������ ���, Ŭ������ �ش� �ൿ�� �� �� �ִ� ���
        // �������̽��� ����ϴ� ��� Ŭ������ ��ȣ�ۿ��� ������ ȿ���� ���� �� ����
        // �������̽��� ���ǵ� �Լ����� Ŭ������ ������ �°� ����� �����ϴ� ��� ���

        public interface IEnterable
        {
            void Enter();
        }

        public abstract class Building : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("�ǹ��� ���ϴ�.");
            }
        }

        // ������ �ǹ��̴� : Ok, ��Ӱ��谡 ����
        public class Bank : Building
        {

        }

        // ���� �� �� �ִ� : Ok, �������̽��� ����
        public class Car : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("�� ���� ���� ���ϴ�.");
            }
        }
    }
}