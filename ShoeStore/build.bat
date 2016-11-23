echo off
set projPath=%1
set destPath=%2
xcopy %projPath%*.config %destPath% /sy
xcopy %projPath%*.asax %destPath% /sy
xcopy %projPath%*.html %destPath% /sy
xcopy %projPath%*.ico %destPath% /sy
xcopy %projPath%*.cshtml %destPath% /sy
xcopy %projPath%*.js %destPath% /sy
xcopy %projPath%*.css %destPath% /sy
xcopy %projPath%*.map %destPath% /sy
xcopy %projPath%*.xml %destPath% /sy
xcopy %projPath%*.png %destPath% /sy
xcopy %projPath%*.jpg %destPath% /sy
xcopy %projPath%fonts\*.* %destPath%fonts\ /sy