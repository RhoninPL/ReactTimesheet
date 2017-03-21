import React from "react";
import Button from 'react-bootstrap/lib/Button';
import FormGroup from 'react-bootstrap/lib/FormGroup';
import FormControl from 'react-bootstrap/lib/FormControl';
import GridTimeSheet from './Grid/GridTimeSheet';
import './Form.scss';

class Form extends React.Component {
    constructor(props) {
        super(props);
        this.state = { hours: [] };
    }

    componentDidMount() {
        this.setState({
            hours: [{
                    Name: "Jan Kowalski",
                    Time: "8h",
                    Company: "Microsoft"
            }, {
                    Name: "Kazimierz Nowak",
                    Time: "8h",
                    Company: "Google"
            }]
        });
    }

    render() {
        return (
            <div className="timesheet-grid">
                <GridTimeSheet hours={this.state.hours} />
                <form>
                    <FormGroup className="form-group">
                        <FormControl type="text" id="company" placeholder="Enter company name" />
                        <FormControl type="text" id="time" placeholder="Enter time" />
                        <Button type="submit">Save</Button>
                    </FormGroup>
                </form>
            </div>
        );
    }
};

export default Form;