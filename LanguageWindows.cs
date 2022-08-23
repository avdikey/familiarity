using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace familiarity_wpf
{
    class LanguageWindows
    {
        public static object[][][] translation { get; set; }
        public static string[][][] Translation { get; set; } = new string[3][][];
        //0 - eng, 1 - ru, 2 - uk
        //0 - titles, 1 - mainwindow, 2 - settings, 3 - players, 4 - playerssecond, 5 - question, 6 - game
        public static string[] Temp { get; set; } = new string[9];
        public static void Translate()
        {
            //выделить место в памяти для разделения на языки
            Translation[0] = new string[7][];
            Translation[1] = new string[7][];
            Translation[2] = new string[7][];


            //выделить место в памяти для разделения на группы
            Translation[0][0] = new string[5];//titles - eng
            Translation[0][1] = new string[3];//mainwindow - eng
            Translation[0][2] = new string[7];//settings - eng
            Translation[0][3] = new string[3];//players - eng
            Translation[0][4] = new string[7];//playerssecond - eng
            Translation[0][5] = new string[5];//question - eng
            Translation[0][6] = new string[9];//game - eng

            Translation[1][0] = new string[5];//titles - ru
            Translation[1][1] = new string[3];//mainwindow - ru
            Translation[1][2] = new string[7];//settings - ru
            Translation[1][3] = new string[3];//players - ru
            Translation[1][4] = new string[7];//playerssecond - ru
            Translation[1][5] = new string[5];//question - ru
            Translation[1][6] = new string[9];//game - ru

            Translation[2][0] = new string[5];//titles - uk
            Translation[2][1] = new string[3];//mainwindow - uk
            Translation[2][2] = new string[7];//settings - uk
            Translation[2][3] = new string[3];//players - uk
            Translation[2][4] = new string[7];//playerssecond - uk
            Translation[2][5] = new string[5];//question - uk
            Translation[2][6] = new string[9];//game - uk


            //translate to english
            Translation[0][0][0] = "Familiarity - Main";
            Translation[0][0][1] = "Familiarity - Players. Step 1";
            Translation[0][0][2] = "Familiarity - Players. Step 2";
            Translation[0][0][3] = "Familiarity - Questions";
            Translation[0][0][4] = "Familiarity - Game";

            Translation[0][1][0] = "Endless game";
            Translation[0][1][1] = "Game with players";
            Translation[0][1][2] = "Settings";

            Translation[0][2][0] = "Cancel";
            Translation[0][2][1] = "Save";
            Translation[0][2][2] = "Language";
            Translation[0][2][3] = "Theme";
            Translation[0][2][4] = "Copyright";
            Translation[0][2][5] = "This application development in Visual Studio 2019 on subsystem WPF using C# and XAML. Not for commercial use. All Rights Reserved.";
            Translation[0][2][6] = "In application uses fonts:";

            Translation[0][3][0] = "Players. Step 1";
            Translation[0][3][1] = "Back";
            Translation[0][3][2] = "Continue";

            Translation[0][4][0] = "Players. Step 2";
            Translation[0][4][1] = "Male";
            Translation[0][4][2] = "Female";
            Translation[0][4][3] = "Previous player";
            Translation[0][4][4] = "Next player";
            Translation[0][4][5] = "Back";
            Translation[0][4][6] = "Continue";

            Translation[0][5][0] = "Questions";
            Translation[0][5][1] = "Choose standart question set";
            Translation[0][5][2] = "Load question set";
            Translation[0][5][3] = "Back";
            Translation[0][5][4] = "Start";

            Translation[0][6][0] = "Game";
            Translation[0][6][1] = "Another question";
            Translation[0][6][2] = "Next player";
            Translation[0][6][3] = "Back";
            Translation[0][6][4] = "Start";
            Translation[0][6][5] = "Endless game";
            Translation[0][6][6] = "Next question";
            Translation[0][6][7] = "Question to ";
            Translation[0][6][8] = "Repeat";


            //translate to russian
            Translation[1][0][0] = "Familiarity - Главная";
            Translation[1][0][1] = "Familiarity - Ввод игроков, шаг 1";
            Translation[1][0][2] = "Familiarity - Ввод игроков, шаг 2";
            Translation[1][0][3] = "Familiarity - Вопросы";
            Translation[1][0][4] = "Familiarity - Игра";

            Translation[1][1][0] = "Играть";
            Translation[1][1][1] = "Ввести игроков";
            Translation[1][1][2] = "Настройки";

            Translation[1][2][0] = "Отмена";
            Translation[1][2][1] = "Сохранить";
            Translation[1][2][2] = "Язык";
            Translation[1][2][3] = "Тема";
            Translation[1][2][4] = "Авторские права";
            Translation[1][2][5] = "Это приложение разработано в Visual Studio 2019 на презентационной подсистеме WPF с использованием C# и XAML. Не для коммерческого использования.";
            Translation[1][2][6] = "Это приложение использует шрифты:";

            Translation[1][3][0] = "Ввод игроков. Шаг 1";
            Translation[1][3][1] = "Вернуться";
            Translation[1][3][2] = "Продолжить";

            Translation[1][4][0] = "Ввод игроков. Шаг 2";
            Translation[1][4][1] = "мужчина";
            Translation[1][4][2] = "женщина";
            Translation[1][4][3] = "Предыдущий игрок";
            Translation[1][4][4] = "Следующий игрок";
            Translation[1][4][5] = "Вернуться";
            Translation[1][4][6] = "Продолжить";

            Translation[1][5][0] = "Вопросы";
            Translation[1][5][1] = "Выбрать стандартный набор вопросов";
            Translation[1][5][2] = "Загрузить набор вопросов";
            Translation[1][5][3] = "Вернуться";
            Translation[1][5][4] = "Начать";

            Translation[1][6][0] = "Игра";
            Translation[1][6][1] = "Другой вопрос";
            Translation[1][6][2] = "Следующий игрок";
            Translation[1][6][3] = "Вернуться";
            Translation[1][6][4] = "Начать";
            Translation[1][6][5] = "Бесконечная игра";
            Translation[1][6][6] = "Следующий вопрос";
            Translation[1][6][7] = "Вопрос к игроку ";
            Translation[1][6][8] = "Повторить";


            //translate to ukrainian
            Translation[2][0][0] = "Familiarity - Головна";
            Translation[2][0][1] = "Familiarity - Гравці";
            Translation[2][0][2] = "Familiarity - Гравці";
            Translation[2][0][3] = "Familiarity - Питання";
            Translation[2][0][4] = "Familiarity - Гра";

            Translation[2][1][0] = "Нескінчена гра";
            Translation[2][1][1] = "Грати з гравцями";
            Translation[2][1][2] = "Налаштування";
            
            Translation[2][2][0] = "Скасувати";
            Translation[2][2][1] = "Зберегти";
            Translation[2][2][2] = "Мова";
            Translation[2][2][3] = "Тема";
            Translation[2][2][4] = "Авторські права";
            Translation[2][2][5] = "Цей застосунок розроблено у програмі Visual Studio 2019 на презентаційній підсистемі WPF з використанням C# и XAML. Не для комерційного використання.";
            Translation[2][2][6] = "В цьому застосунку використовується такі шрифти:";

            Translation[2][3][0] = "Введення відомостей про гравців. Імена";
            Translation[2][3][1] = "Повернутися";
            Translation[2][3][2] = "Далі";

            Translation[2][4][0] = "Введення відомостей про гравців. Стать";
            Translation[2][4][1] = "чоловік";
            Translation[2][4][2] = "жінка";
            Translation[2][4][3] = "Попередній гравець";
            Translation[2][4][4] = "Наступний гравець";
            Translation[2][4][5] = "Повернутися";
            Translation[2][4][6] = "Далі";

            Translation[2][5][0] = "Питання";
            Translation[2][5][1] = "Обрати стандартний набір питань";
            Translation[2][5][2] = "Завантажити набір питань";
            Translation[2][5][3] = "Повернутися";
            Translation[2][5][4] = "Розпочати";


            Translation[2][6][0] = "Гра";
            Translation[2][6][1] = "Інше питання";
            Translation[2][6][2] = "Наступний гравець";
            Translation[2][6][3] = "Повернутися";
            Translation[2][6][4] = "Почати";
            Translation[2][6][5] = "Нескінченна гра";
            Translation[2][6][6] = "Наступне питання";
            Translation[2][6][7] = "Питання до гравця ";
            Translation[2][6][8] = "Повторити";
        }
    }

    class Theme
    {
        public static Brush background_color { get; set; }
        public static Brush background_light_color { get; set; }
        public static Brush main_color { get; set; }
        public static Brush second_color { get; set; }
        public static Brush border_background_color { get; set; }
        public static Brush border_main_color { get; set; }
        public static Brush border_second_color { get; set; }
        public static void ToStandartTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FF7C45D6");
            background_light_color = (Brush)bc.ConvertFrom("#FF946BD6");
            main_color = (Brush)bc.ConvertFrom("#FFD8F800");
            second_color = (Brush)bc.ConvertFrom("#FFFFBA00");
            border_background_color = (Brush)bc.ConvertFrom("#FF2E0571");
            border_main_color = (Brush)bc.ConvertFrom("#FF8DA100");
            border_second_color = (Brush)bc.ConvertFrom("#FFA67900");
        }
        public static void ToFruitsTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FFFF4040");
            background_light_color = (Brush)bc.ConvertFrom("#FFFF7373");
            main_color = (Brush)bc.ConvertFrom("#FF009999");
            second_color = (Brush)bc.ConvertFrom("#FF9FEE00");
            border_background_color = (Brush)bc.ConvertFrom("#FFA60000");
            border_main_color = (Brush)bc.ConvertFrom("#FF006363");
            border_second_color = (Brush)bc.ConvertFrom("#FF679B00");
        }
        public static void ToVioletTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FFFFF800");
            main_color = (Brush)bc.ConvertFrom("#FFC50080");
            second_color = (Brush)bc.ConvertFrom("#FF8370D8");
            border_background_color = (Brush)bc.ConvertFrom("#FFA6A200");
            border_main_color = (Brush)bc.ConvertFrom("#FF800053");
            border_second_color = (Brush)bc.ConvertFrom("#FF1B0773");
            background_light_color = (Brush)bc.ConvertFrom("#FFFFFB73");
        }
        public static void ToSeaTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FF36D986");
            main_color = (Brush)bc.ConvertFrom("#FFFFC073");
            second_color = (Brush)bc.ConvertFrom("#FFDF004F");
            border_background_color = (Brush)bc.ConvertFrom("#FF007439");
            border_main_color = (Brush)bc.ConvertFrom("#FFA65B00");
            border_second_color = (Brush)bc.ConvertFrom("#FF910033");
            background_light_color = (Brush)bc.ConvertFrom("#FF62D99C");
        }
        public static void ToGrayTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FFFFFAF0");
            main_color = (Brush)bc.ConvertFrom("#FFDCDCDC");
            second_color = (Brush)bc.ConvertFrom("#FF778899");
            border_background_color = (Brush)bc.ConvertFrom("#FFFFE4C4");
            border_main_color = (Brush)bc.ConvertFrom("#FF808080");
            border_second_color = (Brush)bc.ConvertFrom("#FF2F4F4F");
            background_light_color = (Brush)bc.ConvertFrom("#FFFFF0F5");
        }
        public static void ToSunriseTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FF63ADD0");
            main_color = (Brush)bc.ConvertFrom("#FFFFB800");
            second_color = (Brush)bc.ConvertFrom("#FFFF6840");
            border_background_color = (Brush)bc.ConvertFrom("#FF034769");
            border_main_color = (Brush)bc.ConvertFrom("#FFA67800");
            border_second_color = (Brush)bc.ConvertFrom("#FFA62300");
            background_light_color = (Brush)bc.ConvertFrom("#FF3CA0D0");
        }
        public static void ToOrangeTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FFFF7400");
            main_color = (Brush)bc.ConvertFrom("#FFFFAB00");
            second_color = (Brush)bc.ConvertFrom("#FFFD0006");
            border_background_color = (Brush)bc.ConvertFrom("#FFA64B00");
            border_main_color = (Brush)bc.ConvertFrom("#FFA66F00");
            border_second_color = (Brush)bc.ConvertFrom("#FFA40004");
            background_light_color = (Brush)bc.ConvertFrom("#FFFF9640");
        }
        public static void ToBlueTheme()
        {
            var bc = new BrushConverter();
            background_color = (Brush)bc.ConvertFrom("#FF0B5FA5");
            main_color = (Brush)bc.ConvertFrom("#FF7573D9");
            second_color = (Brush)bc.ConvertFrom("#FF00AF64");
            border_background_color = (Brush)bc.ConvertFrom("#FF043C6B");
            border_main_color = (Brush)bc.ConvertFrom("#FF333086");
            border_second_color = (Brush)bc.ConvertFrom("#FF007241");
            background_light_color = (Brush)bc.ConvertFrom("#FF66A1D2");
        }
    }
}