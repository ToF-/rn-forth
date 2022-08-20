create romans 
char I c, char V c, char X c, char L c, char C c, char D c, char M c,

: roman-digit ( u -- c )
  romans + c@ ;

