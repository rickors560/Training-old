function sendEmail(){
    console.log(this);
}
var teacher = {
    name:'foo',
    department:'CSE'
}
var student = {
    name:"boo",
    grade:'A',
    department:'ECE'
}
sendEmail.call(teacher);
sendEmail.call(student);