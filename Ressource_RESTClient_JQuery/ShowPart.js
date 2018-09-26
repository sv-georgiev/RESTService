$(document).ready(function() {
    $.ajax({
        url: "http://localhost:51027/api/part/2",
		type: "GET"
    }).then(postCall);
});

function postCall (data) {
       $('.greeting-id').append(data.id);
       $('.greeting-content').append(data.content);
    }