using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter.BL;

namespace Converter
{
    class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IFileManager manager;
        private readonly IMessageService messageService;
        private string filePathExcel;
        private string content;

        public MainPresenter(IMainForm view, IFileManager manager, IMessageService service)
        {
            this.view = view;
            this.manager = manager;
            this.messageService = service;


            this.view.FileOpenClick += View_FileOpenClick;
            this.view.FileSaveClick += View_FileSaveClick;
            this.view.WriteLog += View_WriteLog;

        }

        private void View_WriteLog(object sender, EventArgs e)
        {
            try
            {
                view.Content += manager.WriteLog("Лог сохранён");
                string content = view.Content;
                manager.SaveLog(content, view.FilePathL);
                messageService.ShowMessage("Файл успешно сохранен.");
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }

        }

        private void View_FileOpenClick(object sender, EventArgs e)
        {   //считывание файла
            try
            {
                string filePath = view.FilePathE;
                bool isExist = manager.IsExist(filePath);
                if (!isExist)
                {
                    messageService.ShowExclamation("Выбранный файл не существует.");
                    return;
                }
                filePathExcel = filePath;
                List<string> list = manager.GetContent(filePath);

                //конец считвания файла
                view.Content += manager.WriteLog("Файл загружен");
                //фильтр
                content = manager.Filter(list);
                view.Content += manager.WriteLog("Произведена фильтрация");

            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);

            }
        }

        private void View_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                manager.SaveContent(content, view.FilePathW);

                messageService.ShowMessage("Файл успешно сохранен.");
                view.Content += manager.WriteLog("Файл сохранен в Word");
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }


    }
}