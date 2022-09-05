using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace familiarity_wpf
{
    /// <summary>
    /// Логика взаимодействия для Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {
        string[][][] lang = LanguageWindows.Translation;
        public Questions()
        {
            MakeTempVar();
            InitializeComponent();
            this.Title = lang[Data.language][0][3];
            this.Background = Theme.background_color;
            btViewStandartQuestion.ToolTip = lang[Data.language][7][8];
            EnableButtonStart();
        }
        public void EnableButtonStart()
        {
            if (Data.Endless)
            {
                if (Data.questionEndless.Count != 0)
                    button_start.IsEnabled = true;
            }
            else
            {
                if (Data.questionMale.Count != 0 || Data.questionFemale.Count != 0)
                    button_start.IsEnabled = true;
            }
        }
        public void MakeTempVar()
        {
            LanguageWindows.Temp[0] = lang[Data.language][5][0];
            LanguageWindows.Temp[1] = lang[Data.language][5][1];
            LanguageWindows.Temp[2] = lang[Data.language][5][2];
            LanguageWindows.Temp[3] = lang[Data.language][5][3];
            LanguageWindows.Temp[4] = lang[Data.language][5][4];
            LanguageWindows.Temp[5] = lang[Data.language][5][5];
            LanguageWindows.Temp[6] = lang[Data.language][5][6];
            LanguageWindows.Temp[7] = lang[Data.language][5][7];
            LanguageWindows.Temp[8] = lang[Data.language][5][8];
            LanguageWindows.Temp[9] = lang[Data.language][5][9];
            LanguageWindows.Temp[10] = lang[Data.language][5][10];
            LanguageWindows.Temp[11] = lang[Data.language][5][11];
            LanguageWindows.Temp[12] = lang[Data.language][5][12];
            LanguageWindows.Temp[13] = lang[Data.language][5][13];
            LanguageWindows.Temp[14] = lang[Data.language][5][14];
            LanguageWindows.Temp[15] = lang[Data.language][5][15];
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Endless == false)
            {
                Players_Second window1 = new Players_Second();
                window1.Show();
                Close();
            }
            else
            {
                MainWindow window1 = new MainWindow();
                window1.Show();
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Data.Endless)
                load_endless_questions();
            else
                load_gender_questions();
            button_start.IsEnabled = true;
        }
        private void load_endless_questions()
        {
            switch (Data.language)
            {
                case 0:
                    List<string> quest0 = new List<string>{"Describe yourself in three words.", "What is your favorite hobby?",
                        "Which country would you like to live in?", "What do you value most in your friends?",
                        "Who is an example for you to follow?", "What is your favorite color?", "What is your favorite smell?",
                        "What are you a pro at?", "What is your favorite food?", "What is your favorite game?",
                        "How long ago did you finish school?", "If you had the opportunity, what situation would you like to be in for an hour?",
                        "What language would you like to learn?", "Tea or coffee?", "What is your favorite school subject?", "Android or iPhone?",
                        "What is your biggest dream?", "What are your next goals?", "What cities have you been to?", "What does your name mean?",
                        "What is your favorite series or show?", "Do you play a musical instrument? What would you like to learn to play?",
                        "What is your favorite cartoon character?", "For what do you value life most of all?", "What is your very first memory from childhood?",
                        "The most beautiful place you've been to?", "What's on your window?",
                        "What is scarier for you during your vacation: unbearable heat in the mountains or a storm at sea?", "Have you ever dyed your hair?",
                        "What do you dislike most about cleaning?", "What do you think of the player to your right?", "What do you think of the player to your left?",
                        "How tall are you?", "If you were permanently banned from your current job, what new profession would you choose?",
                        "Would you like to be friends with a person like you?", "If the list of seven wonders of the world had to be compiled again, what would you include in it?",
                        "If your life was a movie, what would it be called?", "What color should the ideal kitchen be?",
                        "You come home from work and see that a clone has taken your place, and friends and family have not noticed the substitution. How to prove that their real relative is you?",
                        "What style of dance would you like to learn?", "How do you prefer to travel?", "What is your favorite drink?",
                        "What is your favorite fruit?", "Who in this room do you know best?", "What would you eat right now?",
                        "How do you spend your free time?", "Name the 5 applications on your phone that you use most often.",
                        "What's the most helpful advice you've been given?", "What is your favorite style of music?", "What should an ideal relationship be like?",
                        "What makes you feel like a child and plunge into childhood?", "How do you evaluate your appearance and character?",
                        "What do you never get tired of doing?", "How do you get rid of negative thoughts?", "How would you spend your last hours in life?",
                        "The best dish you've ever cooked.", "What changed your life outlook radically?",
                        "What is the most boring activity for you?", "What is your favorite style of clothing?", "What compliments do you like to give? And which ones to receive?",
                        "What character traits in others annoy you the most?", "What is your favorite era?", "What were you called as a child?",
                        "What do you like to think about at night and before going to bed?", "What is your favorite writer?", "Who is your favorite music artist?", "Who is your favorite actor and actress?",
                        "What is your best adventure in life?", "What journey do you want to go on?", "Tell us your hidden talent that almost no one knows about.",
                        "What is your best friend?", "Who is your favorite superhero or fictional character?", "Why are you studying or working in this field?",
                        "What is your favorite phrase or quote?"
                    };
                    Data.questionEndless = quest0;
                    break;
                case 1:
                    List<string> quest1 = new List<string>{"Опиши себя в трех словах.", "Твое любимое хобби?",
                        "В какой стране ты хотел(а) бы жить?", "Что ты больше всего ценишь в своих друзьях?",
                        "Кто для тебя пример для подражания?", "Твой любимый цвет?", "Твой любимый запах?",
                        "В каком деле тебя можно назвать профессионалом?", "Твое любимое блюдо?","Твоя любимая игра?",
                        "Как давно ты закончил(а) школу?", "Если бы у тебя была такая возможность, то в какой ситуации ты хотел(а) бы оказаться на час?",
                        "Какой язык ты бы выучил(а)?", "Чай или кофе?", "Твой любимый школьный предмет?", "Android или iPhone?",
                        "Твоя заветная мечта?", "Твои ближайшие цели?", "В каких городах ты был(а)?", "Что означает твое имя?",
                        "Твой любимый сериал или шоу?", "Играешь ли ты на музыкальном инструменте? На каком хотел(а) бы научиться играть?",
                        "Любимый мультгерой?", "За что ты больше всего ценишь жизнь?", "Твое самое первое воспоминание с детства?",
                        "Самое красивое место, в котором ты был(а)?", "Что стоит на твоём окне?",
                        "Что для тебя страшнее во время отпуска: невыносимая жара в горах или шторм на море?", "Красил(а) ли ты когда-нибудь волосы?",
                        "Что в уборке ты не любишь больше всего?", "Что ты думаешь об игроке справа от тебя?", "Что ты думаешь об игроке слева от тебя?",
                        "Твой рост?", "Если бы тебе навсегда запретили заниматься твоей нынешней работой, какую новую профессию ты бы выбрал(а)?",
                        "Хотел(а) бы ты дружить с таким человеком, как ты?", "Если бы список семи чудес света нужно было составить заново, что бы ты в него включил(а)?",
                        "Если бы твоя жизнь была фильмом, как бы он назывался?", "Какого цвета должна быть идеальная кухня?",
                        "Ты возвращаешься домой с работы и видишь, что твоё место занял клон, а друзья и семья не заметили подмены. Как доказать, что их настоящий родственник — ты?",
                        "Какому стилю танцев ты хотел(а) бы научиться?", "Чем ты предпочитаешь путешествовать?", "Твой любимый напиток?",
                        "Твой любимый фрукт?", "Кого в этой комнате ты знаешь лучше всего?", "Что бы ты съел(а) прямо сейчас?",
                        "Как ты проводишь свободное время?","Назви 5 приложений на телефоне, которыми ты пользуешься чаще всего.",
                        "Самый полезный совет, который тебе дали?", "Любимый стиль музыки?", "Какими должны быть идеальные отношения?",
                        "Что заставляет тебя чувствовать ребёнком и окунуться в детство?", "Как ты оцениваешь свою внешность и характер?",
                        "Что тебе никогда не надоест делать?", "Как ты избавляешься от негативных мыслей?", "Как бы ты потратил(а) свои последние часы в жизни?",
                        "Самое лучшее блюдо, что ты когда-либо готовил(а).", "Что изменило твоё жизненное мировоззрение в корне?",
                        "Самая скучное занятие для тебя?", "Твой любимый стиль одежды?", "Какие комплименты любишь говорить? А какие получать?",
                        "Какие черты характера в других больше всего тебя раздражают?", "Твоя любимая эпоха?", "Как тебя называли в детстве?",
                        "О чем любишь думать по ночам и перед сном?", "Твой любимый писатель?", "Твой любимый музыкант?","Твой самый любимый актёр и актриса?",
                        "Твоё лучшее приключение в жизни?", "Путешествие, в которое ты хочешь отправиться?", "Твой скрытый талант, о котором почти никто не знает?",
                        "Твой лучший друг?", "Любимый супергерой или вымышленный персонаж?", "Почему учишься или работаешь в данной сфере?",
                        "Твоя любимая фраза или цитата?"
                    };
                    Data.questionEndless = quest1;
                    break;
                case 2:
                    List<string> quest2 = new List<string>{"Опиши себе у трьох словах.", "Твоє улюблене хобі?",
                        "У якій країні ти хотів(ла) би жити?", "Що ти найбільше цінуєш у своїх друзях?",
                        "Хто тобі приклад для наслідування?", "Твій улюблений колір?", "Твій улюблений запах?",
                        "У якій справі тебе можна назвати професіоналом?", "Твоя улюблена страва?", "Твоя улюблена гра?",
                        "Як давно ти закінчив(ла) школу?", "Якби у тебе була така можливість, то в якій ситуації ти хотів(ла) би опинитися на годину?",
                        "Яку мову ти б вивчив(ла)?", "Чай чи кава?", "Твій улюблений шкільний предмет?", "Android або iPhone?",
                        "Твоя заповітна мрія?", "Твої найближчі цілі?", "У яких містах ти був(ла)?", "Що означає твоє ім'я?",
                        "Твій улюблений серіал чи телешоу?", "Чи граєш ти на музичному інструменті? На якому хотів(ла) би навчитися грати?",
                        "Улюблений мультгерой?", "За що ти найбільше цінуєш життя?", "Твій перший спогад з дитинства?",
                        "Найкрасивіше місце, в якому ти був(ла)?", "Що стоїть на твоєму вікні?", "Чи фарбував(ла) ти колись волосся?",
                        "Що тобі страшніше під час відпустки: нестерпна спека в горах чи шторм на морі?",
                        "Що в прибиранні ти не любиш найбільше?", "Що ти думаєш про гравця праворуч від тебе?", "Що ти думаєш про гравця ліворуч від тебе?",
                        "Твій зріст?", "Якби тобі назавжди заборонили займатися твоєю нинішньою роботою, яку нову професію ти вибрав(ла)?",
                        "Хотів(ла) би ти дружити з такою людиною, як ти?", "Якби список семи чудес світу потрібно було скласти заново, що б ти до нього включив?",
                        "Якби твоє життя було фільмом, як би він називався?", "Якого кольору має бути ідеальна кухня?",
                        "Ти повертаєшся додому з роботи і бачиш, що твоє місце зайняв клон, а друзі та сім'я не помітили підміни. Як довести, що їхній справжній родич - ти?",
                        "Якому стилю танців ти хотів(ла) би навчитися?", "Чим ти вважаєш за краще подорожувати?", "Твій улюблений напій?",
                        "Твій улюблений фрукт?", "Кого в цій кімнаті ти знаєш найкраще?", "Що би ти з'їв(ла) прямо зараз?",
                        "Як ти проводиш вільний час?","Назви 5 додатків на телефоні, якими ти користуєшся найчастіше.",
                        "Найкорисніша порада, яку тобі дали?", "Улюблений стиль музики?", "Якими повинні бути ідеальні стосунки?",
                        "Що змушує тебе відчувати дитиною і поринути в дитинство?", "Як ти оцінюєш свою зовнішність та характер?",
                        "Що тобі ніколи не набридне робити?", "Як ти позбавляєшся негативних думок?", "Як би ти витратив(ла) свою останню годину у житті?",
                        "Найкраща страва, що ти коли-небудь готував(ла).", "Що змінило твій життєвий світогляд у корені?",
                        "Найнудніша справа для тебе?", "Твій улюблений стиль одягу?", "Які компліменти любиш говорити? А які отримувати?",
                        "Які риси характеру в інших тебе найбільше дратують?", "Твоя улюблена епоха?", "Як тебе називали в дитинстві?",
                        "Про що любиш думати вночі, перед сном?", "Твій улюблений письменник?", "Твій улюблений музикант?", "Твої найулюбленіші актор і актриса?",
                        "Твоя найкраща пригода в житті?", "Подорож, до якої ти хочеш вирушити?", "Твій прихований талант, про який майже ніхто не знає?",
                        "Твій найкращий друг?", "Улюблений супергерой чи вигаданий персонаж?", "Чому вчишся або працюєш у цій сфері?",
                        "Твоя улюблена фраза чи цитата?"
                    };
                    Data.questionEndless = quest2;
                    break;
            }
        }
        private void load_gender_questions()
        {
            switch (Data.language)
            {
                case 0:
                    List<string> questMale0 = new List<string>{"Describe yourself in three words.", "What is your favorite hobby?",
                        "Which country would you like to live in?", "What do you value most in your friends?",
                        "Who is an example for you to follow?", "What is your favorite color?", "What is your favorite smell?",
                        "What are you a pro at?", "What is your favorite food?", "What is your favorite game?",
                        "How long ago did you finish school?", "If you had the opportunity, what situation would you like to be in for an hour?",
                        "What language would you like to learn?", "Tea or coffee?", "What is your favorite school subject?", "Android or iPhone?",
                        "What is your biggest dream?", "What are your next goals?", "What cities have you been to?", "What does your name mean?",
                        "What is your favorite series or show?", "Do you play a musical instrument? What would you like to learn to play?",
                        "What is your favorite cartoon character?", "For what do you value life most of all?", "What is your very first memory from childhood?",
                        "The most beautiful place you've been to?", "What's on your window?",
                        "What is scarier for you during your vacation: unbearable heat in the mountains or a storm at sea?", "Have you ever dyed your hair?",
                        "What do you dislike most about cleaning?", "What do you think of the player to your right?", "What do you think of the player to your left?",
                        "How tall are you?", "If you were permanently banned from your current job, what new profession would you choose?",
                        "Would you like to be friends with a person like you?", "If the list of seven wonders of the world had to be compiled again, what would you include in it?",
                        "If your life was a movie, what would it be called?", "What should be the ideal garage?",
                        "You come home from work and see that a clone has taken your place, and friends and family have not noticed the substitution. How to prove that their real relative and friend is you?",
                        "What style of dance would you like to learn?", "How do you prefer to travel?", "What is your favorite drink?",
                        "What is your favorite fruit?", "Who in this room do you know best?", "What would you eat right now?",
                        "How do you spend your free time?", "Name the 5 applications on your phone that you use most often.",
                        "What's the most helpful advice you've been given?", "What is your favorite style of music?", "What should an ideal relationship be like?",
                        "What makes you feel like a child and plunge into childhood?", "How do you evaluate your appearance and character?",
                        "What do you never get tired of doing?", "How do you get rid of negative thoughts?", "How would you spend your last hours in life?",
                        "The best dish you've ever cooked.", "What changed your life outlook radically?",
                        "What is the most boring activity for you?", "What is your favorite style of clothing?", "What compliments do you like to give? And which ones to receive?",
                        "What character traits in others annoy you the most?", "What is your favorite era?", "What were you called as a child?",
                        "What do you like to think about at night and before going to bed?", "What is your favorite writer?", "Who is your favorite music artist?", "Who is your favorite actor and actress?",
                        "What is your best adventure in life?", "What journey do you want to go on?", "Tell us your hidden talent that almost no one knows about.",
                        "What is your best friend?", "Who is your favorite superhero or fictional character?", "Why are you studying or working in this field?",
                        "What is your favorite phrase or quote?", "What brand was or should be your first car?", "Which is worse: not driving a car for a year or being without a phone for a month?"
                    };
                    List<string> questFemale0 = new List<string>{"Describe yourself in three words.", "What is your favorite hobby?",
                        "Which country would you like to live in?", "What do you value most in your friends?",
                        "Who is an example for you to follow?", "What is your favorite color?", "What is your favorite smell?",
                        "What are you a pro at?", "What is your favorite food?", "What is your favorite game?",
                        "How long ago did you finish school?", "If you had the opportunity, what situation would you like to be in for an hour?",
                        "What language would you like to learn?", "Tea or coffee?", "What is your favorite school subject?", "Android or iPhone?",
                        "What is your biggest dream?", "What are your next goals?", "What cities have you been to?", "What does your name mean?",
                        "What is your favorite series or show?", "Do you play a musical instrument? What would you like to learn to play?",
                        "What is your favorite cartoon character?", "For what do you value life most of all?", "What is your very first memory from childhood?",
                        "The most beautiful place you've been to?", "What's on your window?",
                        "What is scarier for you during your vacation: unbearable heat in the mountains or a storm at sea?", "Have you ever dyed your hair?",
                        "What do you dislike most about cleaning?", "What do you think of the player to your right?", "What do you think of the player to your left?",
                        "How tall are you?", "If you were permanently banned from your current job, what new profession would you choose?",
                        "Would you like to be friends with a person like you?", "If the list of seven wonders of the world had to be compiled again, what would you include in it?",
                        "If your life was a movie, what would it be called?", "What color should the ideal kitchen be?",
                        "You come home from work and see that a clone has taken your place, and friends and family have not noticed the substitution. How to prove that their real relative and friend is you?",
                        "What style of dance would you like to learn?", "How do you prefer to travel?", "What is your favorite drink?",
                        "What is your favorite fruit?", "Who in this room do you know best?", "What would you eat right now?",
                        "How do you spend your free time?", "Name the 5 applications on your phone that you use most often.",
                        "What's the most helpful advice you've been given?", "What is your favorite style of music?", "What should an ideal relationship be like?",
                        "What makes you feel like a child and plunge into childhood?", "How do you evaluate your appearance and character?",
                        "What do you never get tired of doing?", "How do you get rid of negative thoughts?", "How would you spend your last hours in life?",
                        "The best dish you've ever cooked.", "What changed your life outlook radically?",
                        "What is the most boring activity for you?", "What is your favorite style of clothing?", "What compliments do you like to give? And which ones to receive?",
                        "What character traits in others annoy you the most?", "What is your favorite era?", "What were you called as a child?",
                        "What do you like to think about at night and before going to bed?", "What is your favorite writer?", "Who is your favorite music artist?", "Who is your favorite actor and actress?",
                        "What is your best adventure in life?", "What journey do you want to go on?", "Tell us your hidden talent that almost no one knows about.",
                        "What is your best friend?", "Who is your favorite superhero or fictional character?", "Why are you studying or working in this field?",
                        "What is your favorite phrase or quote?", "What's worse: not going to a beauty salon for six months or being without a phone for a month?", "Your worst hairstyle?", "People say girls are always late. Is this about you?"
                    };
                    Data.questionFemale = questFemale0;
                    Data.questionMale = questMale0;
                    break;
                case 1:
                    List<string> questMale1 = new List<string>{"Опиши себя в трех словах.", "Твое любимое хобби?",
                        "В какой стране ты хотел бы жить?", "Что ты больше всего ценишь в своих друзьях?",
                        "Кто для тебя пример для подражания?", "Твой любимый цвет?", "Твой любимый запах?",
                        "В каком деле тебя можно назвать профессионалом?", "Твое любимое блюдо?","Твоя любимая игра?",
                        "Как давно ты закончил школу?", "Если бы у тебя была такая возможность, то в какой ситуации ты хотел бы оказаться на час?",
                        "Какой язык ты бы выучил?", "Чай или кофе?", "Твой любимый школьный предмет?", "Android или iPhone?",
                        "Твоя заветная мечта?", "Твои ближайшие цели?", "В каких городах ты был?", "Что означает твое имя?",
                        "Твой любимый сериал или шоу?", "Играешь ли ты на музыкальном инструменте? На каком хотел бы научиться играть?",
                        "Любимый мультгерой?", "За что ты больше всего ценишь жизнь?", "Твое самое первое воспоминание с детства?",
                        "Самое красивое место, в котором ты был?", "Что стоит на твоём окне?",
                        "Что для тебя страшнее во время отпуска: невыносимая жара в горах или шторм на море?", "Красил ли ты когда-нибудь волосы?",
                        "Что в уборке ты не любишь больше всего?", "Что ты думаешь об игроке справа от тебя?", "Что ты думаешь об игроке слева от тебя?",
                        "Твой рост?", "Если бы тебе навсегда запретили заниматься твоей нынешней работой, какую новую профессию ты бы выбрал?",
                        "Хотел бы ты дружить с таким человеком, как ты?", "Если бы список семи чудес света нужно было составить заново, что бы ты в него включил?",
                        "Если бы твоя жизнь была фильмом, как бы он назывался?", "Каким должен быть идеальный гараж?",
                        "Ты возвращаешься домой с работы и видишь, что твоё место занял клон, а друзья и семья не заметили подмены. Как доказать, что их настоящий родственник и друг — ты?",
                        "Какому стилю танцев ты хотел бы научиться?", "Чем ты предпочитаешь путешествовать?", "Твой любимый напиток?",
                        "Твой любимый фрукт?", "Кого в этой комнате ты знаешь лучше всего?", "Что бы ты съел прямо сейчас?",
                        "Как ты проводишь свободное время?", "Назви 5 приложений на телефоне, которыми ты пользуешься чаще всего.",
                        "Самый полезный совет, который тебе дали?", "Любимый стиль музыки?", "Какими должны быть идеальные отношения?",
                        "Что заставляет тебя чувствовать ребёнком и окунуться в детство?", "Как ты оцениваешь свою внешность и характер?",
                        "Что тебе никогда не надоест делать?", "Как ты избавляешься от негативных мыслей?", "Как бы ты потратил свои последние часы в жизни?",
                        "Самое лучшее блюдо, что ты когда-либо готовил.", "Что изменило твоё жизненное мировоззрение в корне?",
                        "Самая скучное занятие для тебя?", "Твой любимый стиль одежды?", "Какие комплименты любишь говорить? А какие получать?",
                        "Какие черты характера в других больше всего тебя раздражают?", "Твоя любимая эпоха?", "Как тебя называли в детстве?",
                        "О чем любишь думать по ночам и перед сном?", "Твой любимый писатель?", "Твой любимый музыкант?","Твой самый любимый актёр и актриса?",
                        "Твоё лучшее приключение в жизни?", "Приключение, которое ты хочешь совершить?", "Твой скрытый талант, о котором почти никто не знает?",
                        "Твой лучший друг?", "Любимый супергерой или вымышленный персонаж?", "Почему учишься или работаешь в данной сфере?",
                        "Твоя любимая фраза или цитата?", "Какой была или должна быть твоя первая машина?", "Что хуже: год не ездить на автомобиле или месяц быть без телефона?"
                    };
                    List<string> questFemale1 = new List<string>{"Опиши себя в трех словах.", "Твое любимое хобби?", "Говорят, девушки всегда долго собираются. Это про тебя?",
                        "В какой стране ты хотела бы жить?", "Что ты больше всего ценишь в своих друзьях?",
                        "Кто для тебя пример для подражания?", "Твой любимый цвет?", "Твой любимый запах?",
                        "В каком деле тебя можно назвать профессионалом?", "Твое любимое блюдо?","Твоя любимая игра?",
                        "Как давно ты закончила школу?", "Если бы у тебя была такая возможность, то в какой ситуации ты хотела бы оказаться на час?",
                        "Какой язык ты бы выучила?", "Чай или кофе?", "Твой любимый школьный предмет?", "Android или iPhone?",
                        "Твоя заветная мечта?", "Твои ближайшие цели?", "В каких городах ты была?", "Что означает твое имя?",
                        "Твой любимый сериал или шоу?", "Играешь ли ты на музыкальном инструменте? На каком хотела бы научиться играть?",
                        "Любимый мультгерой?", "За что ты больше всего ценишь жизнь?", "Твое самое первое воспоминание с детства?",
                        "Самое красивое место, в котором ты была?", "Что стоит на твоём окне?", "Твоя худшая причёска?",
                        "Что для тебя страшнее во время отпуска: невыносимая жара в горах или шторм на море?", "Красила ли ты когда-нибудь волосы?",
                        "Что в уборке ты не любишь больше всего?", "Что ты думаешь об игроке справа от тебя?", "Что ты думаешь об игроке слева от тебя?",
                        "Твой рост?", "Если бы тебе навсегда запретили заниматься твоей нынешней работой, какую новую профессию ты бы выбрала?",
                        "Хотела бы ты дружить с таким человеком, как ты?", "Если бы список семи чудес света нужно было составить заново, что бы ты в него включила?",
                        "Если бы твоя жизнь была фильмом, как бы он назывался?", "Какого цвета должна быть идеальная кухня?",
                        "Ты возвращаешься домой с работы и видишь, что твоё место занял клон, а друзья и семья не заметили подмены. Как доказать, что их настоящая родственница и подруга — ты?",
                        "Какому стилю танцев ты хотела бы научиться?", "Чем ты предпочитаешь путешествовать?", "Твой любимый напиток?",
                        "Твой любимый фрукт?", "Кого в этой комнате ты знаешь лучше всего?", "Что бы ты съела прямо сейчас?", "Что хуже: полгода не ходить в салон красоты или месяц быть без телефона?",
                        "Как ты проводишь свободное время?","Назви 5 приложений на телефоне, которыми ты пользуешься чаще всего.",
                        "Самый полезный совет, который тебе дали?", "Любимый стиль музыки?", "Какими должны быть идеальные отношения?",
                        "Что заставляет тебя чувствовать ребёнком и окунуться в детство?", "Как ты оцениваешь свою внешность и характер?",
                        "Что тебе никогда не надоест делать?", "Как ты избавляешься от негативных мыслей?", "Как бы ты потратила свои последние часы в жизни?",
                        "Самое лучшее блюдо, что ты когда-либо готовила.", "Что изменило твоё жизненное мировоззрение в корне?",
                        "Самая скучное занятие для тебя?", "Твой любимый стиль одежды?", "Какие комплименты любишь говорить? А какие получать?",
                        "Какие черты характера в других больше всего тебя раздражают?", "Твоя любимая эпоха?", "Как тебя называли в детстве?",
                        "О чем любишь думать по ночам и перед сном?", "Твой любимый писатель?", "Твой любимый музыкант?","Твой самый любимый актёр и актриса?",
                        "Твоё лучшее приключение в жизни?", "Приключение, которое ты хочешь совершить?", "Твой скрытый талант, о котором почти никто не знает?",
                        "Твой лучший друг?", "Любимый супергерой или вымышленный персонаж?", "Почему учишься или работаешь в данной сфере?",
                        "Твоя любимая фраза или цитата?"
                    };
                    Data.questionMale = questMale1;
                    Data.questionFemale = questFemale1;
                    break;
                case 2:
                    List<string> questFemale2 = new List<string>{"Опиши себе у трьох словах.", "Твоє улюблене хобі?",
                        "У якій країні ти хотів би жити?", "Що ти найбільше цінуєш у своїх друзях?",
                        "Хто тобі приклад для наслідування?", "Твій улюблений колір?", "Твій улюблений запах?",
                        "У якій справі тебе можна назвати професіоналом?", "Твоя улюблена страва?", "Твоя улюблена гра?",
                        "Як давно ти закінчив школу?", "Якби у тебе була така можливість, то в якій ситуації ти хотів би опинитися на годину?",
                        "Яку мову ти б вивчив?", "Чай чи кава?", "Твій улюблений шкільний предмет?", "Android або iPhone?",
                        "Твоя заповітна мрія?", "Твої найближчі цілі?", "У яких містах ти був?", "Що означає твоє ім'я?",
                        "Твій улюблений серіал чи телешоу?", "Чи граєш ти на музичному інструменті? На якому хотів би навчитися грати?",
                        "Улюблений мультгерой?", "За що ти найбільше цінуєш життя?", "Твій перший спогад з дитинства?",
                        "Найкрасивіше місце, в якому ти був?", "Що стоїть на твоєму вікні?", "Чи фарбував ти колись волосся?",
                        "Що тобі страшніше під час відпустки: нестерпна спека в горах чи шторм на морі?",
                        "Що в прибиранні ти не любиш найбільше?", "Що ти думаєш про гравця праворуч від тебе?", "Що ти думаєш про гравця ліворуч від тебе?",
                        "Твій зріст?", "Якби тобі назавжди заборонили займатися твоєю нинішньою роботою, яку нову професію ти би вибрав?",
                        "Хотів би ти дружити з такою людиною, як ти?", "Якби список семи чудес світу потрібно було скласти заново, що б ти до нього включив?",
                        "Якби твоє життя було фільмом, як би він називався?", "Яким має бути ідеальний гараж?",
                        "Ти повертаєшся додому з роботи і бачиш, що твоє місце зайняв клон, а друзі та сім'я не помітили підміни. Як довести, що їхній справжній родич та друг - ти?",
                        "Якому стилю танців ти хотів би навчитися?", "Чим ти вважаєш за краще подорожувати?", "Твій улюблений напій?",
                        "Твій улюблений фрукт?", "Кого в цій кімнаті ти знаєш найкраще?", "Що би ти з'їв прямо зараз?",
                        "Як ти проводиш вільний час?","Назви 5 додатків на телефоні, якими ти користуєшся найчастіше.",
                        "Найкорисніша порада, яку тобі дали?", "Улюблений стиль музики?", "Якими повинні бути ідеальні стосунки?",
                        "Що змушує тебе відчувати дитиною і поринути в дитинство?", "Як ти оцінюєш свою зовнішність та характер?",
                        "Що тобі ніколи не набридне робити?", "Як ти позбавляєшся негативних думок?", "Як би ти витратив свою останню годину у житті?",
                        "Найкраща страва, що ти коли-небудь готував.", "Що змінило твій життєвий світогляд у корені?",
                        "Найнудніша справа для тебе?", "Твій улюблений стиль одягу?", "Які компліменти любиш говорити? А які отримувати?",
                        "Які риси характеру в інших тебе найбільше дратують?", "Твоя улюблена епоха?", "Як тебе називали в дитинстві?",
                        "Про що любиш думати вночі, перед сном?", "Твій улюблений письменник?", "Твій улюблений музикант?", "Твої найулюбленіші актор і актриса?",
                        "Твоя найкраща пригода в житті?", "Подорож, до якої ти хочеш вирушити?", "Твій прихований талант, про який майже ніхто не знає?",
                        "Твій найкращий друг?", "Улюблений супергерой чи вигаданий персонаж?", "Чому вчишся або працюєш у цій сфері?",
                        "Твоя улюблена фраза чи цитата?", "Якою була чи має бути твоя перша машина?", "Що гірше: рік не їздити автомобілем чи місяць бути без телефону?"
                    };
                    List<string> questMale2 = new List<string>{"Опиши себе у трьох словах.", "Твоє улюблене хобі?",
                        "У якій країні ти хотіла би жити?", "Що ти найбільше цінуєш у своїх друзях?",
                        "Хто тобі приклад для наслідування?", "Твій улюблений колір?", "Твій улюблений запах?",
                        "У якій справі тебе можна назвати професіоналом?", "Твоя улюблена страва?", "Твоя улюблена гра?",
                        "Як давно ти закінчила школу?", "Якби у тебе була така можливість, то в якій ситуації ти хотіла б опинитися на годину?",
                        "Яку мову ти б вивчила?", "Чай чи кава?", "Твій улюблений шкільний предмет?", "Android або iPhone?",
                        "Твоя заповітна мрія?", "Твої найближчі цілі?", "У яких містах ти була?", "Що означає твоє ім'я?",
                        "Твій улюблений серіал чи телешоу?", "Чи граєш ти на музичному інструменті? На якому хотіла би навчитися грати?",
                        "Улюблений мультгерой?", "За що ти найбільше цінуєш життя?", "Твій перший спогад з дитинства?",
                        "Найкрасивіше місце, в якому ти була?", "Що стоїть на твоєму вікні?", "Чи фарбувала ти колись волосся?",
                        "Що тобі страшніше під час відпустки: нестерпна спека в горах чи шторм на морі?",
                        "Що в прибиранні ти не любиш найбільше?", "Що ти думаєш про гравця праворуч від тебе?", "Що ти думаєш про гравця ліворуч від тебе?",
                        "Твій зріст?", "Якби тобі назавжди заборонили займатися твоєю нинішньою роботою, яку нову професію ти вибрала?",
                        "Хотіла би ти дружити з такою людиною, як ти?", "Якби список семи чудес світу потрібно було скласти заново, що б ти до нього включив?",
                        "Якби твоє життя було фільмом, як би він називався?", "Якого кольору має бути ідеальна кухня?",
                        "Ти повертаєшся додому з роботи і бачиш, що твоє місце зайняв клон, а друзі та сім'я не помітили підміни. Як довести, що їхній справжня родичка - ти?",
                        "Якому стилю танців ти хотіла би навчитися?", "Чим ти вважаєш за краще подорожувати?", "Твій улюблений напій?",
                        "Твій улюблений фрукт?", "Кого в цій кімнаті ти знаєш найкраще?", "Щоб ти з'їла прямо зараз?",
                        "Як ти проводиш вільний час?","Назви 5 додатків на телефоні, якими ти користуєшся найчастіше.",
                        "Найкорисніша порада, яку тобі дали?", "Улюблений стиль музики?", "Якими повинні бути ідеальні стосунки?",
                        "Що змушує тебе відчувати дитиною і поринути в дитинство?", "Як ти оцінюєш свою зовнішність та характер?",
                        "Що тобі ніколи не набридне робити?", "Як ти позбавляєшся негативних думок?", "Як би ти витратила свою останню годину у житті?",
                        "Найкраща страва, що ти коли-небудь готувала.", "Що змінило твій життєвий світогляд у корені?",
                        "Найнудніша справа для тебе?", "Твій улюблений стиль одягу?", "Які компліменти любиш говорити? А які отримувати?",
                        "Які риси характеру в інших тебе найбільше дратують?", "Твоя улюблена епоха?", "Як тебе називали в дитинстві?",
                        "Про що любиш думати вночі, перед сном?", "Твій улюблений письменник?", "Твій улюблений музикант?", "Твої найулюбленіші актор і актриса?",
                        "Твоя найкраща пригода в житті?", "Подорож, до якої ти хочеш вирушити?", "Твій прихований талант, про який майже ніхто не знає?",
                        "Твій найкращий друг?", "Улюблений супергерой чи вигаданий персонаж?", "Чому вчишся або працюєш у цій сфері?",
                        "Твоя улюблена фраза чи цитата?", "Що гірше: півроку не ходити в салон краси чи місяць бути без телефону?", "Твоя найгірша зачіска?", "Кажуть, дівчата завжди довго збираються. Це про тебе?"
                    };

                    Data.questionMale = questMale2;
                    Data.questionFemale = questFemale2;
                    break;
            }
        }
        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            Game window1 = new Game();
            window1.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Data.Endless)
            {
                ViewQuestions window = new ViewQuestions
                {
                    Owner = this,
                    Background = Theme.background_color
                };
                _ = window.ShowDialog();

            }
            else
            {
                ViewGenderQuestions window = new ViewGenderQuestions
                {
                    Owner = this,
                    Background = Theme.background_color
                };
                _ = window.ShowDialog();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            button_start.IsEnabled = true;
            LoadQuestionSet lqs = new LoadQuestionSet
            {
                Background = Theme.background_light_color,
                BorderBrush = Theme.border_background_color,
                BorderThickness = new Thickness(3)
            };
            _ = lqs.ShowDialog();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            EnableButtonStart();
        }
    }
}
