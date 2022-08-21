require ffl/tst.fs
require rn.fs

page

." romans table" cr
t{ 
  romans c@ char I ?s  
}t
." column# variable" cr
t{
  ones column# @ 0 ?s
  tens column# @ 2 ?s
  hundreds column# @ 4 ?s
  thousands column# @ 6 ?s
}t
." column" cr
t{
  hundreds column c@ char C ?s
}t
." .symbol" cr
t{
  tens 1 .symbol \ should emit a L
  ones 1 .symbol \ should emit a V
  cr
}t
." oner, fiver, tener" cr
t{
  hundreds
  oner \ should emit a C
  fiver \ should emit a D
  tener \ should emit a M
  cr
}t
." oners" cr
t{ 
  thousands 3 oners \ should emit MMM
  cr
}t
." almost" cr
t{
  tens 0 almost cr \ should emit XL
  1 almost cr \ should emit XC
}t
." digit" cr
t{
    tens 7 digit \ should emit LXX
    cr
}t
." roman" cr
t{
    3827 roman \ should emit MMMDCCCXXVII
    cr
}t
bye
