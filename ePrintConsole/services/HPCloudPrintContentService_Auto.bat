@ECHO OFF
sc config CPContentService start= auto
net start CPContentService /y