using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Handler.CMD
{
    internal class WriterUtility
    {
        public static int options = 0;

        public static void writeLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WindowUtility.centerText(@"                ,.,   '           ,. -  .,                             _,.,  °                 ,. -,    ");
            WindowUtility.centerText(@"              ;´   '· .,        ,' ,. -  .,  `' ·,               ,.·'´  ,. ,  `;\ '         ,.·'´,    ,'\  ");
            WindowUtility.centerText(@"            .´  .-,    ';\      '; '·~;:::::'`,   ';\          .´   ;´:::::\`'´ \'\     ,·'´ .·´'´-·'´::::\' ");
            WindowUtility.centerText(@"           /   /:\:';   ;:'\'     ;   ,':\::;:´  .·´::\'       /   ,'::\::::::\:::\:'   ;    ';:::\::\::;:'  ");
            WindowUtility.centerText(@"         ,'  ,'::::'\';  ;::';     ;  ·'-·'´,.-·'´:::::::';     ;   ;:;:-·'~^ª*';\'´     \·.    `·;:'-·'´  ");
            WindowUtility.centerText(@"     ,.-·'  '·~^*'´¨,  ';::;   ;´    ':,´:::::::::::·´'      ;  ,.-·:*'´¨'`*´\::\ '     \:`·.   '`·, ");
            WindowUtility.centerText(@"     ':,  ,·:²*´¨¯'`;  ;::';    ';  ,    `·:;:-·'´          ;   ;\::::::::::::'\;'        `·:'`·,   \'   ");
            WindowUtility.centerText(@"     ,'  / \::::::::';  ;::';    ; ,':\'`:·.,  ` ·.,         ;  ;'_\_:;:: -·^*';\         ,.'-:;'  ,·\  ");
            WindowUtility.centerText(@"    ,' ,'::::\·²*'´¨¯':,'\:;     \·-;::\:::::'`:·-.,';       ';    ,  ,. -·:*'´:\:'\°  ,·'´     ,.·´:::'\  ");
            WindowUtility.centerText(@"    \`¨\:::/          \::\'      \::\:;'` ·:;:::::\::\'      \`*´ ¯\:::::::::::\;' '  \`*'´\::::::::;·'‘  ");
            WindowUtility.centerText(@"     '\::\;'            '\;'  '     '·-·'       `' · -':::''       \:::::\;::-·^*'´        \::::\:;:·´   ");
            WindowUtility.centerText(@"       `¨'                                                      `*´¯                   '`*'´‘            ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void optionsWriter(string text)
        {
            options++;
            Console.WriteLine($"{options}.) {text}");
        }

        public static void resetOptions()
        {
            options = 0;
        }
    }
}
