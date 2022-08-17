using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Logo
    {
        public static void WriteLogo()
        {
            string logo = @"   ____      _      _        ____   _   _   _          _      _____    ___    ____  
  / ___|    / \    | |      / ___| | | | | | |        / \    |_   _|  / _ \  |  _ \ 
 | |       / _ \   | |     | |     | | | | | |       / _ \     | |   | | | | | |_) |
 | |___   / ___ \  | |___  | |___  | |_| | | |___   / ___ \    | |   | |_| | |  _ < 
  \____| /_/   \_\ |_____|  \____|  \___/  |_____| /_/   \_\   |_|    \___/  |_| \_\
                                                                                    ";
            Console.WriteLine(logo);
        }
    }
}
