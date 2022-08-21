create romans char I c, char V c,
              char X c, char L c,
              char C c, char D c,
              char M c,

variable column#

: ones 0 column# ! ;
: tens 2 column# ! ;
: hundreds 4 column# ! ;
: thousands 6 column# ! ;

: column ( -- address of column )
  romans column# @ + ;

: .symbol ( offset -- )
  column + c@ emit ;

: oner
  0 .symbol ;

: fiver
  1 .symbol ;

: tener
  2 .symbol ;

: oners ( # of oners -- )
  ?dup if 0 do oner loop then ;

: almost ( quotient of 5 / -- )
  oner if tener else fiver then ;

: digit ( digit -- )
  5 /mod over 4 = if 
    almost drop 
  else 
    if fiver then 
    oners 
  then ;

: roman ( number -- )
  1000 /mod thousands digit
   100 /mod  hundreds digit
    10 /mod      tens digit
                 ones digit ;
