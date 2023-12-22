function loadSection(section) {
    const contentContainer = document.getElementById('content-container');
    const xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function() {
        if (xhr.readyState == 4 && xhr.status == 200) {
            contentContainer.innerHTML = xhr.responseText;
        }
    };

    xhr.open('GET', 'sections/' + section, true);
    xhr.send();
}
