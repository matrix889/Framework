﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib.API.Debugger;
using CatLib.API.Routing;

namespace CatLib.Debugger.WebConsole.Routed
{
    /// <summary>
    /// 通用
    /// </summary>
    [Routed("debug://util")]
    public class Util
    {
        /// <summary>
        /// 回显
        /// </summary>
        /// <param name="request">请求</param>
        /// <param name="logger">日志系统</param>
        [Routed]
        public void Echo(IRequest request , ILogger logger)
        {
            if (logger != null)
            {
                logger.Debug(request.Uri.OriginalString);
                return;
            }

        }
    }
}
