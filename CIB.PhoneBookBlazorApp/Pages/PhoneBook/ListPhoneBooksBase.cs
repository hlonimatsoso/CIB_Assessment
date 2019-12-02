using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIB.Models;
using CIB.Interfaces;

namespace CIB.PhoneBookBlazorApp.Pages.PhoneBook
{
    public class ListPhoneBooksBase : ComponentBase
    {
        [Inject] IPhoneBookService PhoneBookService { get; set; }

        public List<Models.PhoneBook> _phoneBookList;

        public string PhoneBookListURL { get { return $"{Constants.BASE_URL}/phonebook/list"; } }



        public bool IsLoading { get; set; }


        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            _phoneBookList = await PhoneBookService.GetAllPhoneBooksAsync();
            //await Task.Delay(1000);
            IsLoading = false;

        }


    }

}
