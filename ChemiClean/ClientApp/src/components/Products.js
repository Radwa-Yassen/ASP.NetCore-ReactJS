import React, { Component } from 'react';

export class Products extends Component {
    state = { products: [], loading: true };

    componentDidMount() {
        this.getProductsData();
    }

    static renderProductsTable(products) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Product Name</th>
                        <th>Supplier Name</th>
                        <th>Has Data Copy</th>
                        <th>Changed Recently</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map(product =>
                        <tr key={product.id}>
                            <td><a href={product.url} target="_blank">{product.productName}</a></td>
                            <td>{product.supplierName}</td>
                            {product.copyExistance ? <td style={{ color: "green" }} >Yes </td> : <td style={{ color: "orange" }} >No </td>}
                            {product.recentlyChanged ? <td style={{ color: "green" }} >Yes </td> : <td>- </td>}
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Products.renderProductsTable(this.state.products);

        return (
            <div>
                <h1 id="tabelLabel" >ChemiClean</h1>
                <p>The safety data sheets </p>
                {contents}
            </div>
        );
    }

    async getProductsData() {
        const response = await fetch('Product');
        const data = await response.json();
        this.setState({ products: data, loading: false });
    }
}
