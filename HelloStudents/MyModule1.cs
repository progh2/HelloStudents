using System;
using System.Web;

namespace HelloStudents
{
    public class MyModule1 : IHttpModule
    {
        /// <summary>
        /// 이 모듈을 사용하려면 먼저 웹의 Web.config 파일에서 모듈을
        /// 구성하고 IIS에 등록해야 합니다.
        /// 다음 링크 참조: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule 멤버

        public void Dispose()
        {
            //여기에서 코드를 정리합니다.
        }

        public void Init(HttpApplication context)
        {
            // 다음은 LogRequest 이벤트를 처리하여 사용자 지정 로깅 구현을 
            // 이 이벤트에 제공하는 예입니다.
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //사용자 지정 로깅 논리를 여기에 사용할 수 있습니다.
        }
    }
}
