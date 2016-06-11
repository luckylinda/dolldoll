using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyJCalendar.Pages;
using Xamarin.Forms;

namespace MyJCalendar
{
    public class App : Application
    {
        public App()
        {
            //시작페이지로 회사 추가 페이지 설정 
            MainPage = new NewCompanyPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
