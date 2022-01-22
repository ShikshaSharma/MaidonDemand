var express=require('express');
var mysql=require('mysql2');
var app=express();
app.listen(8080,function(){
	console.log("server started on 8080");
	});	
var con=mysql.createConnection({
	host:"localhost",
	user:"root",
	password:"root@123",
	database:"knowit211"	
	});

con.connect(function(err){
	if(!err)
	console.log('connected');
	else
	console(err.toString());
	})

app.get('/greet',function(req,res){
	res.sendFile(__dirname + "/greetform.html");
	});

app.get('/greetpage',function(req,res){
	console.log("welcome");
	var empno=req.query.empno;
	con.query('select * from emp where empno='+empno, function(err,result){
	if(!err){
	var str="Welcome"+result[0].ENAME;
	var date=new Date();
	console.log(date.getHours());
	if(date.getHours()<=12)
	{
		var str1="Good Morning";
	}
	else if (date.getHours()>=12 && date.getHours()<=17)
	{
		var str1="Good Afternoon";
	}
	else if(date.getHours()>=17 && date.getHours()<=20)
	{
		var str1="good Evening";
	}
	else
	{
		var str1="good night";
	}
	var obj={
		msg:str,Greet:str1
		}
		res.json(JSON.stringify(obj));
}
});

});

app.all('*', function (req, res) {
	res.send('Sorry, Invalid URL');
})