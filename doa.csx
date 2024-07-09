using System;
using System.Text.RegularExpressions;
// 将sqlstr字符串里面=前面的字段取出来
string sqlstr = "sourcingType1 = 1 and sourcingType in (N'媒体寻源',N'投资人/分析师寻源') and (ifFilmOrInterview=N'是' OR ifSpecialPeriod=N'是')";
        // 定义正则表达式模式
        Regex regex = new Regex(@"(\S+)\s*=(?!=)|\s(\w+)\s+in(?=\s*\()|\((\w+)\s*=");

        MatchCollection matches = regex.Matches(sqlstr);

        foreach (Match match in matches)
        {
            // 获取匹配的结果
            string fieldValue = match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
            Console.WriteLine(fieldValue);
        }

// // 定义分隔符数组
// string[] separators = { " and ", " in ", "(", ")", " OR ", "=" };

// // 使用分隔符分割SQL语句
// string[] segments = sqlstr.Split(separators, StringSplitOptions.RemoveEmptyEntries);

// // 输出分割结果
// foreach (string segment in segments)
// {
//     Console.WriteLine(segment.Trim());
// }