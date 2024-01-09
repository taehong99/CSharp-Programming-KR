using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Callback
    {
        /*******************************************************************************
         * �ݹ��Լ�
         * 
         * ��������Ʈ�� �̿��Ͽ� Ư�����ǿ��� �����ϴ� �Լ��� ����
         * �Լ��� ȣ��(Call)�� �ƴ� ������ ȣ����� �� ������ �����Ͽ� ��ȣ��(Callback)
         *******************************************************************************/

        void Main()
        {
            File file = new File();

            Button saveButton = new Button();
            saveButton.callback = file.Save;

            Button loadButton = new Button();
            loadButton.callback = file.Load;

            saveButton.Click();     // output : �����ϱ� �մϴ�.
            loadButton.Click();     // output : �ҷ����� �մϴ�.
        }

        public class Button
        {
            public Action callback;

            public void Click()
            {
                if (callback != null)
                    callback();
            }
        }

        public class File
        {
            public void Save()
            {
                Console.WriteLine("�����ϱ� �մϴ�.");
            }

            public void Load()
            {
                Console.WriteLine("�ҷ����� �մϴ�.");
            }
        }
    }
}