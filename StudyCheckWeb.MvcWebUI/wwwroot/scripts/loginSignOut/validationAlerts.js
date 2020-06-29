function AlertErrors(title, desc, type) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000
    });

    toastr.options.progressBar = true;

    switch (type) {
        case "exception":
            toastr['error'](desc, title);
            break;
        case "message":
            toastr['warning'](desc, title);
            break;
        case "success":
            toastr['success'](desc, title);
            break;
    }
}

function warning(baslik,desc) {
    $(document).Toasts('create', {
        class: 'bg-danger',
        title: baslik,
        subtitle: 'Dikkat',
        body: desc
    });
}