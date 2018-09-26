$(document).ready(function() {
    $.ajax({
        url: "http://rest-service.guides.spring.io/greeting"
    }).then(postCall);
});

function postCall (data) {
       $('.greeting-id').append(data.id);
       $('.greeting-content').append(data.content);
    }