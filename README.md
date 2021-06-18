# NetCore-Web-GravarImagem

Este projeto tem como objetivo demonstrar a funcionalidade de gravar arquivos na base de dados através do SqlServer

Executar antes de iniciar o projeto
Add-Migration "CriarBaseDeDados"
Update-Database

O Formulário deve conter a configuração  <form asp-action="Create" enctype="multipart/form-data">.
