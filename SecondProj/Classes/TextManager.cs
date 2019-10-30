using System.Windows.Forms;

namespace SecondProj
{
    public class TextManager
    {
        public static void TextBuild(Label _label1, Regression obj)
        {
            _label1.Text = $"Коеф. детерминации: {obj.Det}  \n" +
                          $"Ошибка аппроксимации: {obj.Aprox} \n" +
                          $"Адекватна ли модель(F-stat) {obj.FStat}\n" +
                          $"Критерий Стьюдента: {obj.Stud}\n";
        }
    }
}
