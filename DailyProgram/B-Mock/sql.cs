select city,max(marks) from #students group by city;

UPDATE #EMPLOYEES SET SALARY=SALARY*1.1 WHERE JOB_TITLE='MANAGER' ;
SELECT * FROM #EMPLOYEES;
