﻿using System;

namespace _210720_Demon03_LogServiceDLL {
    //用于控制台输出日志
    class ConsoleLogService : ILogService {
        public void LogErr(string msgErr) {
            Console.WriteLine($"打印的错误日志为{msgErr}");
        }

        public void LogInfo(string msgInfo) {
            Console.WriteLine($"打印的信息日志为{msgInfo}");
        }
    }
}
