﻿import React from "react";
import Grid from 'react-bootstrap/lib/Grid';
import Row from 'react-bootstrap/lib/Row';
import Col from 'react-bootstrap/lib/Col';
import './GridTimeSheet.scss';

class GridTimeSheet extends React.Component {
    constructor(props) {
        super(props);
        this.state = { hours: [] };
    }

    render() {
        return (
            <table className="grid-time table-responsive table-hover">
                <tbody>
                    {this.props.hours.map(hour => {
                        return <tr>
                            <td>{hour.Name}</td>
                            <td>{hour.Time}h</td>
                            <td>{hour.Company}</td>
                        </tr>
                    })}
                </tbody>
            </table>
        );
    }
};

export default GridTimeSheet;