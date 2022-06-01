: empty		s" ---marker--- marker ---marker---" evaluate ;
: edit		s" vim test.fs" system ;
: run		s" test.fs" included ;
: ecr		edit run ;

marker ---marker---
