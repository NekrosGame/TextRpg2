using System.Collections.Generic; // ����Ʈ ����� ���� using ���ù�
internal class ���� public class�� ��������. ������ �ٸ� ������ ������� �����ϱ�


namespace TextRpg2 //���ӽ����̽� ���� ���� ������Ʈ�� �������� ������ ���ӽ����̽��� Ŭ�������� �׷�ȭ�ϴ� �������, 
                   //���� �̸��� Ŭ������ ������ �� �ְ� ���ش�.
{
    public class Startstory // Ŭ������ ���� ����
    {
        public void Start()  // �޼��� ���� ����
        {
            Console.WriteLine("�ؽ�Ʈ");
        }
    }
}


A a = New A(); // �ν��Ͻ� ����
a.�޼���(); // �޼��� ȣ��
�ڷ��� ������ = a.������ // a��� �ν��Ͻ��� ������ �������� ���
                         // ��, a.�������� public���� ����Ǿ� �־�� �Ѵ�. public �ڷ��� ������{ get; set; } ���·� �����ؾ� �Ѵ�.}





public class Memo // Ŭ������ ���� ����
{
	public string Title { get; set; } // ����
	public string Content { get; set; } // ����
	// get�� �б� ����, set�� ���� �������� ������ �� �ִ�.


	public List<string> Tags { get; set; } // �±� ���


	public Memo(string title, string content, List<string> tags)  // ������ ���� ����
	{
		Title = title;
		Content = content;
		Tags = tags;
	}
