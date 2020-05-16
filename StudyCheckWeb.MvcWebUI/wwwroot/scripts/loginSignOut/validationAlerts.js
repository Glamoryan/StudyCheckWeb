function AlertErrors(title, desc, type) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000        
    });

    toastr.options.progressBar = true;

    if (type == 'exception') {
        toastr['error'](desc, title);
    }
    else if (type == 'message') {
        toastr['warning'](desc, title);
    }
    else if (type == 'success') {
        toastr['success'](desc, title);
    }
}