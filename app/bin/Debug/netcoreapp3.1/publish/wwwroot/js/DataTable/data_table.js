function initDataTable() {
    var records = []
    for (let permit of temp_data) {
        var temp = [permit["permitnum"], permit["permit_type"], permit["permit_subtype"], permit["status"], permit["issue_date"]]
        records.push(temp);
    }
    const options = {
        columns: [
            {
                name: 'Permit Number',
                editable: false,
                resizeable: false,
                focusable: false
            },
            {
                name: 'Permit Type',
                editable: false,
                resizeable: false,
                focusable: false
            },
            {
                name: 'Permit Subtype',
                editable: false,
                resizeable: false,
                focusable: false
            },
            {
                name: 'Status',
                editable: false,
                resizeable: false,
                focusable: false
            },
            {
                name: 'Issued Date',
                editable: false,
                resizeable: true,
                focusable: false,
                widith: 30
            }
        ],
        data: records,
        layout: "fixed",
        noDataMessage: "No Permits were Found",
        dynamicRowHeight: true,
    }

    const datatable = new DataTable('#datatable', options);
}
