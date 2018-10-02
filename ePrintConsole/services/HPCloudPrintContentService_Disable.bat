@ECHO OFF
net stop CPContentService /y
sc config CPContentService start= disabled
