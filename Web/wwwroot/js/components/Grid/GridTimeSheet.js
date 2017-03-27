import React from "react";
import Grid from 'react-bootstrap/lib/Grid';
import Row from 'react-bootstrap/lib/Row';
import Col from 'react-bootstrap/lib/Col';

class GridTimeSheet extends React.Component {
    constructor(props) {
        super(props);
        this.state = { hours: [] };
    }

    render() {
        return (
            <Grid>
                {this.props.hours.map(hour => {
                    return <Row className="show-grid">
                        <Col>{hour.Name}</Col>
                        <Col>{hour.Time}h</Col>
                        <Col>{hour.Company}</Col>
                    </Row>})}
            </Grid>
        );
    }
};

export default GridTimeSheet;